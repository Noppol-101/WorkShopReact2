﻿namespace Workshop01.BackEnd.Model.Request.ManageUser;

    public class CheckInRequest
    {

    }

    public class InsertCheckInRequest
{
        public int Id { get; set; }  
}

    public class SelectCheckInRequest
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public DateOnly? CheckInDate { get; set; }
}

