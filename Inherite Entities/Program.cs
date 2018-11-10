using System;

public class TextInput
{
    private string input = string.Empty;

    public void Add(char c)
    {
        if (isValueValid(c))
            input += c.ToString();
    }

    protected virtual bool isValueValid(char c)
    {
        return char.IsLetterOrDigit(c);
    }

    public string GetValue()
    {
        return input;
    }
}

public class NumericInput : TextInput
{

    protected override bool isValueValid(char c)
    {
        return char.IsDigit(c);
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}
