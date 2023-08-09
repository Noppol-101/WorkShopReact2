﻿namespace Workshop01.BackEnd.Model.Response.ManageUser;

    public class ManageUserResponse
    {

    }

    public class ManageUserList
{
    public List<ManageUserModel> dataUser { get; set; } = new();
}

    public class ManageUserModel
{
    public int id { get; set; }
    public int StudentId { get; set; }
    public string StudentName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string BirthDay { get; set; } = string.Empty;
}
