namespace MauiScientificCalculator;

public static class MauiProgram
{
	/// <param name="platform">Extra setup from the host that creates the app (the MauiWeb web host passes UseMauiWeb).</param>
	public static MauiApp CreateMauiApp(Action<MauiAppBuilder> platform = null)
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Cairo-Light.ttf", "RegularFont");
                fonts.AddFont("Cairo-ExtraLight.ttf", "LightFont");
            });

		platform?.Invoke(builder);

		return builder.Build();
	}
}
