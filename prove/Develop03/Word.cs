public class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenText;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _hiddenText = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
       public bool IsHidden()
    {
        return _isHidden;
    }

public void HideLetter(char letter)
{
    char[] chars = _hiddenText.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
        if (char.ToLower(chars[i]) == letter)
        {
            chars[i] = '_';
        }
    }

    _hiddenText = new string(chars);
}

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _hiddenText;
        }
    }
}