namespace Todo.Common;

//
// Ok or Error. And need to accomodate return datao
//

public class Result
{
    private bool ok;

    public string Error { get; private set; }

    private Result()
    {
        this.ok = true;
        this.Error = string.Empty;
    }

    private Result(string error)
    {
        this.ok = false;
        this.Error = error;
    }

    public static Result Ok()
    {
        return new Result();
    }

    public static Result Err(string error)
    {
        return new Result(error);
    }
}

public class Result<T>
    where T : class
{
    private bool ok;

    private string error; 

    private T? value; 

    public bool IsErr()
    {
        return this.ok;
    }

    public bool IsOk()
    {
       return this.ok; 
    }

    public string GetErr()
    {
        return this.error;
    }

    public T? GetVal()
    {
        return this.value;
    }

    private Result(T val)
    {
        this.value = val;
        this.ok = true;
        this.error = string.Empty;
    }

    private Result(string error)
    {
        this.value = null;
        this.ok = false;
        this.error = error;
    }

    public static Result<T> Ok(T val)
    {
        return new Result<T>(val);
    }

    public static Result<T> Err(string error)
    {
        return new Result<T>(error);
    }
}
