namespace ApplicationCore.Models.DomainModels;

public record Log(int LogId, int UserId, string UserType, string Message);