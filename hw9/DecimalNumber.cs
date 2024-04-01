namespace hw9
{
    struct DecimalNumber
    {
        public string Value { get; set; }
        public DecimalNumber(string value)
        {
            Value = value;
        }
        public string DecimalToBinary()
        {
            int decimalNum = int.Parse(Value);
            if (decimalNum == 0)
            {
                return "0";
            }

            string binaryNumber = string.Empty;
            while (decimalNum > 0)
            {
                binaryNumber = (decimalNum % 2) + binaryNumber;
                decimalNum /= 2;
            }
            return binaryNumber;
        }
        public string DecimalToOctal()
        {
            int decimalNum = int.Parse(Value);
            if (decimalNum == 0)
            {
                return "0";
            }

            string octalNumber = string.Empty;

            while (decimalNum > 0)
            {
                octalNumber = (decimalNum % 8) + octalNumber;
                decimalNum /= 8;
            }

            return octalNumber;
        }
        public string DecimalToHexadecimal()
        {
            int decimalNum = int.Parse(Value);
            if (decimalNum == 0)
            {
                return "0";
            }

            string hexadecimalNumber = string.Empty;

            while (decimalNum > 0)
            {
                if ((decimalNum % 16) > 10)
                {
                    hexadecimalNumber = ((char)(decimalNum % 16) - 10 + 'A') + hexadecimalNumber;
                }
                hexadecimalNumber = (decimalNum % 16) + hexadecimalNumber;
                decimalNum /= 16;
            }

            return hexadecimalNumber;
        }
        public override string ToString() => $"{Value}";
    }
}
