﻿using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) :base(message)
        {
            
        }
        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = new();
            foreach (var error in validationResult.ErrorMessage)
            {
                ValidationErrors.Add(error.ToString());
            }
        }
        public List<string> ValidationErrors { get; set; }
    }
}
