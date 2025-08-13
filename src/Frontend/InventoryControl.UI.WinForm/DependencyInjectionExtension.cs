using InventoryControl.UI.WinForms.Factories;
using InventoryControl.UI.WinForms.Forms;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Services.Providers;
using InventoryControl.UI.WinForms.Services.Services.Item;
using InventoryControl.UI.WinForms.Services.Services.ItemHistory;
using InventoryControl.UI.WinForms.Services.Services.User;
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
}
