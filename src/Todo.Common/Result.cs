namespace Todo.Common;

//
// Ok or Error. And need to accomodate return datao
//

public class Result
{
    private bool ok;

    public string Error {get; private set;}

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

public class Result<T> where T : class
{
    private bool ok;

    public string Error {get; private set;}

    public T? Value { get; private set; }

    private Result(T val)
    {
        this.Value = val;
        this.ok = true;
        this.Error = string.Empty;
    }

    private Result(string error)
    {
        this.Value = null;
        this.ok = false;
        this.Error = error;
    }


    public static Result Ok(T val)
    {
        return new Result(val);
    }

    public static Result Err(string error)
    {
        return new Result(error);
    }
}
