﻿namespace CompanyPosts.Application.DTO.Response;
public record AuthResultDTO(bool IsSuccess, string Message , string? Token = null);