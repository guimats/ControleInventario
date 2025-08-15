using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Exceptions.Handlers;
using InventoryControl.UI.WinForms.Factories;
using InventoryControl.UI.WinForms.Forms;
using InventoryControl.UI.WinForms.Providers;
using InventoryControl.UI.WinForms.Services.Item.Filter;
using InventoryControl.UI.WinForms.Services.Item.Update;
using InventoryControl.UI.WinForms.Services.Item.Write;
using InventoryControl.UI.WinForms.Services.ItemHistory;
using InventoryControl.UI.WinForms.Services.User.Auth;
using InventoryControl.UI.WinForms.Services.User.ChangePassword;
using InventoryControl.UI.WinForms.Services.User.GetProfile;
using InventoryControl.UI.WinForms.Services.User.Register;
using InventoryControl.UI.WinForms.Services.User.Update;
using InventoryControl.UI.WinForms.Validators;
using InventoryControl.UI.WinForms.Validators.PasswordRules;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.UI.WinForms;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddServices(services);
        AddForms(services);
        AddPasswordRules(services);
        AddFactory(services);
        AddExceptions(services);
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddSingleton<IHttpClientProvider, HttpClientProvider>();
        services.AddSingleton<IAuthService, AuthService>();
        services.AddTransient<IRegisterUserService, RegisterUserService>();
        services.AddTransient<IUpdateItemService, UpdateItemService>();
        services.AddTransient<IFilterItensService, FilterItensService>();
        services.AddTransient<IWriteItemService, WriteItemService>();
        services.AddTransient<IItemHistoryService, ItemHistoryService>();
        services.AddTransient<IGetUserProfileService, GetUserProfileService>();
        services.AddTransient<IUpdateUserService, UpdateUserService>();
        services.AddTransient<IChangePasswordService, ChangePasswordService>();
        services.AddTransient<PasswordValidator>();
    }

    private static void AddForms(IServiceCollection services)
    {
        services.AddTransient<MainForm>();
        services.AddTransient<ChangePasswordForm>();
        services.AddTransient<ItemForm>();
        services.AddTransient<ItemListForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<MainForm>();
        services.AddTransient<ProfileForm>();
        services.AddTransient<UserRegisterForm>();
    }

    private static void AddPasswordRules(IServiceCollection services)
    {
        services.AddTransient<IPasswordRuleBase, NotEmptyRule>();
        services.AddTransient<IPasswordRuleBase, DifferentFromCurrentRule>();
        services.AddTransient<IPasswordRuleBase, MatchConfirmationRule>();
        services.AddTransient<IPasswordRuleBase, MinLengthRule>();
    }

    private static void AddFactory(IServiceCollection services)
    {
        services.AddTransient<IFormFactory, FormFactory>();
    }

    private static void AddExceptions(IServiceCollection services)
    {
        services.AddSingleton<IExceptionHandler, ExpiredTokenHandler>();
        services.AddSingleton<IExceptionHandler, InventoryControlHandler>();
        services.AddSingleton<IExceptionHandler, FrontendExceptionHandler>();
        services.AddSingleton<ExceptionFilter>();
    }
}
