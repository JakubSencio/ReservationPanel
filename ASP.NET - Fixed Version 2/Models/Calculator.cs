namespace ASP.NET___Fixed_Version_2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public String Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Subtract:
                        return "-";
                    case Operators.Multiply:
                        return "*";
                    case Operators.Divide:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            if (!IsValid())
            {
                return double.NaN;
            }

            switch (Operator)
            {
                case Operators.Add:
                    return (double)(X + Y);
                case Operators.Subtract:
                    return (double)(X - Y);
                case Operators.Multiply:
                    return (double)(X * Y);
                case Operators.Divide:
                    if (Y == 0)
                    {
                        return double.NaN; // Nie można dzielić przez zero
                    }
                    return (double)(X / Y);
                default:
                    return double.NaN;
            }
        }
    }