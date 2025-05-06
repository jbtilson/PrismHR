using RestSharp;

namespace PrismHRAPI.Models;

public class RequestParameter
{

	public string? name { get; set; }
	public object value { get; set; } = string.Empty;
	public ParameterType type { get; set; }

	public RequestParameter(string name, string value, ParameterType type)
	{
		this.name = name;
		this.value = value;
		this.type = type;
	}

}

