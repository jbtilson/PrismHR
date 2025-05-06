using System;
using System.Net;
using System.Text.Json;

namespace PrismHRAPI.Models;

public class APIReturnModel
{
    public string? errorCode { get; set; }
    public string? errorMessage { get; set; }
    public string? sessionId { get; set; }
    public object? APIResult { get; set; }
}

public static class APIReturnModelExtensions {
    public static APIReturnModel ToModel<T>(this APIReturnModel returnModel)
    {
        var result = returnModel.APIResult;
        if (result != null) returnModel.APIResult = JsonSerializer.Deserialize<T>(Convert.ToString(result)!);
        return returnModel;
    }
}

