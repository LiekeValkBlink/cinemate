﻿namespace Cinemate.API.Model
{
    public class UserDto
    {
        public required string Username { get; set; }
        public  required string PasswordHash { get; set; }
    }
}
