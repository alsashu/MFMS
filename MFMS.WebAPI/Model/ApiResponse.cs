﻿namespace MFMS.WebAPI.Model
{
    public class ApiResponse
    {
        public string Code { get; set; }=string.Empty;
        public string Message { get; set; }= string.Empty;
        public object? Payload { get; set; }
    }
    public enum ResponseType
    {
        Success,
        NotFound,
        Failure
    }
}
