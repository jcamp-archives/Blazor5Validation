﻿using Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blazor5Validation.Server.Extensions
{
    public static class BaseResultExtensions
    {
        public static T Success<T>(this T result, string message = null) where T : BaseResult
        {
            result.IsSuccessful = true;
            if (message != null)
            {
                result.Message = message;
            }
            return result;
        }
        
        public static T Failed<T>(this T result, string message = null) where T : BaseResult
        {
            result.IsSuccessful = false;
            if (message != null)
            {
                result.Message = message;
            }
            return result;
        }

        public static T Errors<T>(this T result, ModelStateDictionary modelState) where T : BaseResult
        {
            result.IsSuccessful = false;
            result.Errors = modelState.ToDictionary();
            return result;
        }
        
        public static ActionResult ToActionResult(this BaseResult result)
        {
            
            if (!result.IsSuccessful)
            {
                return new BadRequestObjectResult(result);
            }

            return new OkObjectResult(result);
        }

        
    }
}
