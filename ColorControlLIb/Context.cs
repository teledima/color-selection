namespace ColorControlLIb
{
    public class Context
    {
        private IMask mask;

        public void SetMask(IMask mask)
        {
            this.mask = mask;
        }

        public bool CheckMask(string text)
        {
            return mask.IsValid(text);
        }

        public object ParseText(string text)
        {
            return mask.ParseText(text);
        }

        public int GetDecimal(string text)
        {
            return mask.getDecimalNumber(text);
        }
    }
}
