namespace milijunas;

public class question
{
    private string _question;
    private string _option1, _option2, _option3, _option4;
    private string _right;

    public question(string question, string option1, string option2,string option3, string option4, string right)
    {
        this._question= question;
        this._option1 = option1;
        this._option2 = option2;
        this._option3 = option3;
        this._option4 = option4;
        this._right = right;
    }

    public string Question
    {
        get{return _question;}
    }
    public string Option1
    {
        get{return _option1;}
    }
    public string Option2
    {
        get{return _option2;}
    }
    public string Option3   
    {
        get{return _option3;}
    }
    public string Option4
    {
        get{return _option4;}
    }
    public string Right
    {
        get{return _right;}
    }
    public static string ToLowerFirstChar(string input)
    {
        if(string.IsNullOrEmpty(input))
            return input;
    
        return char.ToLower(input[0]) + input.Substring(1);
    }
    
}