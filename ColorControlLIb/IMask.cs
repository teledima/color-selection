namespace ColorControlLIb
{
    public interface IMask
    {
        bool IsValid(string text);
        object ParseText(string text);

        int GetDecimalNumber(string text);
    }
}
