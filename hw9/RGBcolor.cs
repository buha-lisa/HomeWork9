using System;

namespace hw9
{
    struct RGBcolor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public RGBcolor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string decToHexa(int n)
        {
            char[] hexaDeciNum = new char[2];

            int i = 0;
            while (n != 0)
            {
                int temp = 0;
                temp = n % 16;

                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 55);
                    i++;
                }
                n = n / 16;
            }
            string hexCode = "";

            if (i == 2)
            {
                hexCode += hexaDeciNum[0];
                hexCode += hexaDeciNum[1];
            }
            else if (i == 1)
            {
                hexCode = "0";
                hexCode += hexaDeciNum[0];
            }
            else if (i == 0)
                hexCode = "00";
            return hexCode;
        }

        public string RGBToHEX()
        {
            string HEX = "#";

            HEX += decToHexa(Red);
            HEX += decToHexa(Green);
            HEX += decToHexa(Blue);

            return HEX;
        }

        public void RGBToHSL()
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double delta = max - min;

            double H = 0;
            double S = 0;
            double L = (max + min) / 2.0;

            if (delta != 0)
            {
                S = delta / (1 - Math.Abs(2 * L - 1));
                if (max == r)
                {
                    H = 60 * (((g - b) / delta) % 6);
                }
                else if (max == g)
                {
                    H = 60 * (((b - r) / delta) + 2);
                }
                else if (max == b)
                {
                    H = 60 * (((r - g) / delta) + 4);
                }
            }

            H = H < 0 ? H + 360 : H;
            H = Math.Round(H);
            S = Math.Round(S * 100);
            L = Math.Round(L * 100);
            Console.WriteLine($"HSL:  ({H}, {S}%, {L}%)");
        }
        public void RGBToCMYK()
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double K = 1 - Math.Max(r, Math.Max(g, b));
            double C = (1 - r - K) / (1 - K);
            double M = (1 - g - K) / (1 - K);
            double Y = (1 - b - K) / (1 - K);

            C = Math.Round(C);
            M = Math.Round(M);
            Y = Math.Round(Y);
            K = Math.Round(K);
            Console.WriteLine($"CMYL: ({C}, {M}, {Y}, {K})");
        }


        public override string ToString() => $"({Red}, {Green}, {Blue})";
    }
}
