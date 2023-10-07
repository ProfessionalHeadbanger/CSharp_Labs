using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку для хеширования: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            // Преобразование введенной строки в байтовый формат
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            SHA256 sha256 = new SHA256();
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            // Преобразование байтов хеша в строку в шестнадцатеричном формате
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            Console.WriteLine("Хеш SHA-256: " + hashString);
        }
    }
}

class SHA256
{
    private uint[] H;
    private uint[] K;
    private int dataLength;

    public SHA256()
    {
        // Начальные значения хеш-сумм - первые 32 бита дробных частей квадратных корней первых восьми простых чисел
        H = new uint[]  
        {
            0x6a09e667, 0xbb67ae85, 0x3c6ef372, 0xa54ff53a,
            0x510e527f, 0x9b05688c, 0x1f83d9ab, 0x5be0cd19
        };
        // Начальные значения округленных констант - первые 32 бита дробных частей кубических корней первых 64 простых чисел
        K = new uint[]
        {
            0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5,
            0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
            0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3,
            0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
            0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc,
            0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
            0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7,
            0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
            0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13,
            0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
            0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3,
            0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
            0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0bcb5,
            0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
            0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208,
            0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2
        };

        dataLength = 0;
    }

    public byte[] ComputeHash(byte[] data)
    {
        // 1) Определяем длину исходных данных и сохраняем ее
        // 2) Вычисляем, сколько нужно добавить байтов до длины одного блока. Блок = 64 байта = 512 бит
        // 3) В конце последовательности блоков должны содержаться 8 байт = 64 бита информации о длине изначальной строки
        // 4) Соответственно, если остается меньше 8 байтов, то добавляем еще блок в 64 байта
        // 5) Количество данных всегда кратно 64 байтам = 512 битам
        dataLength = data.Length;
        int initialLength = dataLength;
        int paddingLength = 64 - (dataLength % 64);
        if (paddingLength < 8)
        {
            paddingLength += 64;
        }
        // 6) Умножаем на 8, так как работаем с битами
        dataLength *= 8;
        // 7) Создаем массив для хранения данных вместе с длиной и копируем туда эти данные
        // 8) В первый байт после данных записываем 10000000 = 0x80
        // 9) В цикле с левого края последних 8 байт записываем длину
        // 10) Так как длина изначально переводится в 8 байт, можно использовать операцию битового сдвига на нужное количество бит
        // Пример: длина строки была 256 бит = 32 байта = 00000000 00000000 00000000 00000000 00000000 00000000 00000001 00000000
        // Начиная с левого байта последних 8 байт массива будем переписывать биты, применяя битовый сдвиг и операцию И с байтом 11111111
        // Пример шага для заданной длины: 00000000... >> 56 = 00000000 & 11111111 = 00000000 - получили самый первый байт из 8
        byte[] paddedData = new byte[initialLength + paddingLength];
        Array.Copy(data, paddedData, initialLength);
        paddedData[initialLength] = 0x80;
        for (int i = 0; i < 8; i++)
        {
            paddedData[paddedData.Length - 8 + i] = (byte)((dataLength >> (56 - i * 8)) & 0xFF);
        }
        // 11) Создаем массив М, куда переносим все байты данных в формате целого беззнакового числа (4 байта)
        // 12) 4 байта = 32 бита, каждые 4 байта массива paddedData объединяются в одно число
        // 13) Массив М будет хранить блок 512 бит в виде последовательности 16 чисел, если данных больше (1024 бита например), то чисел будет больше
        uint[] M = new uint[paddedData.Length / 4];
        for (int i = 0; i < paddedData.Length; i += 4)
        {
            M[i / 4] = (uint)(paddedData[i] << 24 | paddedData[i + 1] << 16 | paddedData[i + 2] << 8 | paddedData[i + 3]);
        }
        // 13) В цикле будет обрабатываться один блок, то есть 16 чисел за раз
        for (int i = 0; i < M.Length; i += 16)
        {
            // 14) Создаем массив W для хранения расширенных слов
            // 15) Копируем первый блок в массив расширенных слов (первые 16 элементов), остальные 48 будут рассчитываться по формулам
            uint[] W = new uint[64];
            for (int j = 0; j < 16; j++)
            {
                W[j] = M[i + j];
            }
            // 16) Рассчитываем по формулам остальные 48 чисел
            // RotateRight - операция поворота вправо, почти то же самое, что и битовый сдвиг, только последние биты не затираются, а переносятся в начало
            // ^ - XOR
            for (int j = 16; j < 64; j++)
            {
                uint s0 = RotateRight(W[j - 15], 7) ^ RotateRight(W[j - 15], 18) ^ (W[j - 15] >> 3);
                uint s1 = RotateRight(W[j - 2], 17) ^ RotateRight(W[j - 2], 19) ^ (W[j - 2] >> 10);
                W[j] = W[j - 16] + s0 + W[j - 7] + s1;
            }
            // 17) Записываем изначальные значения промежуточных хешей
            uint a = H[0];
            uint b = H[1];
            uint c = H[2];
            uint d = H[3];
            uint e = H[4];
            uint f = H[5];
            uint g = H[6];
            uint h = H[7];
            // 18) Обрабатываем каждое из 64 расширенных слов
            for (int j = 0; j < 64; j++)
            {
                uint S1 = RotateRight(e, 6) ^ RotateRight(e, 11) ^ RotateRight(e, 25); // S1 - крутите барабан
                uint ch = (e & f) ^ (~e & g); // ch = choice - выбираем бит из f и g на основе бита e, 1 - из f, 0 - из g
                uint temp1 = h + S1 + ch + K[j] + W[j]; // Ну тут просто формула с набором операций
                uint S0 = RotateRight(a, 2) ^ RotateRight(a, 13) ^ RotateRight(a, 22); // S0 - опять крутим барабан
                uint maj = (a & b) ^ (a & c) ^ (b & c); // maj = majority - выбираем бит, который встречается чаще всего на определенной позиции
                uint temp2 = S0 + maj; // Тоже формула
                // 19) Обновляем промежуточные хеши, все по формулам как умные дяди сказали
                h = g;
                g = f;
                f = e;
                e = d + temp1;
                d = c;
                c = b;
                b = a;
                a = temp1 + temp2;
            }
            // 20) Прибавляем к хеш-суммам посчитанные промежуточные хеши
            H[0] += a;
            H[1] += b;
            H[2] += c;
            H[3] += d;
            H[4] += e;
            H[5] += f;
            H[6] += g;
            H[7] += h;
        }
        // 21) Создаем массив, куда запишется конечный хеш. Размер - 32 байта, или 256 бит (длина хеша короче)
        // 22) Чтобы запихнуть все в массив, нужно сначала сконвертировать хеш-сумму в массив байтов, а потом скопировать на нужное место
        byte[] hashBytes = new byte[32];
        for (int i = 0; i < 8; i++)
        {
            byte[] temp = BitConverter.GetBytes(H[i]);
            Array.Copy(temp, 0, hashBytes, i * 4, 4);
        }
        return hashBytes;
    }

    // Правый поворот, он же - правый побитовый циклический сдвиг
    private uint RotateRight(uint value, int count)
    {
        return (value >> count) | (value << (32 - count));
    }
}