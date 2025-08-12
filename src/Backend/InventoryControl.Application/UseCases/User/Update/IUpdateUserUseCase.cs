﻿using InventoryControl.Communication.Requests;

namespace InventoryControl.Application.UseCases.User.Update;

public interface IUpdateUserUseCase
{
    public Task Execute(RequestUpdateUserJson request);
}
