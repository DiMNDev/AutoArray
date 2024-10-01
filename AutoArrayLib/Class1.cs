namespace AutoArrayLib;

public class MyList
{
    private string[] data = [1024];

    public void Push(string newData)
    {
        for (int i = 0; i < data.length; i++)
        {
            if (data[i] == null)
            {
                data[i] = newData;
                break;
            }
        }
    }

    public string Get(int index)
    {
        return data[i]?? throw new excecption("Value is null") 
    }
}
