﻿namespace AdminPanelWeb.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
