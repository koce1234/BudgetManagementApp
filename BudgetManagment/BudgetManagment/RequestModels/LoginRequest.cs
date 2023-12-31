﻿using System.Text.Json.Serialization;

namespace BudgetManagment.RequestModels;

public class LoginRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("password")]
    public string Password { get; set; }
}