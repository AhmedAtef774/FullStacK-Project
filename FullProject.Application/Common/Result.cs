public class Result {

    public bool IsSuccess{get;}

    public bool IsFailure => !IsSuccess;

    public Error Error {get;}

    public String? SuccessMessage {get;}

    protected Result(bool isSuccess, Error error, string? successMessage = null){
        IsSuccess = isSuccess;
        Error = error;
        SuccessMessage = successMessage;
    }

    public static Result Success(string? successMessage = null) => new Result(true, Error.None, successMessage);

    public static Result Failure(Error error) => new Result(false, error);

}

public class Result<T> : Result {

    public T? Value {get;}

    protected Result(T? value,bool isSuccess, Error error, string? successMessage = null) : base(isSuccess, error, successMessage) {
        Value = value;
    }

    public static Result<T> Success(T value, string? successMessage = null) => new Result<T>(value, true, Error.None, successMessage);

    public static new Result<T> Failure(Error error) => new Result<T>(default, false, error);
    
}
