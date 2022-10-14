using System.Text.Json;
using DnDCharacterSheets;
using Microsoft.JSInterop;
public class SessionStorage
{
    private readonly IJSRuntime jsRuntime;

    public SessionStorage(IJSRuntime JSRuntime)
    {
        jsRuntime = JSRuntime;
    }
    public async Task Save(DnDCharacter character)
    {
        var characterJson = JsonSerializer.Serialize(character, new JsonSerializerOptions() { WriteIndented = true });
        await jsRuntime.InvokeVoidAsync("localStorage.setItem", "dndCharacter", characterJson);
    }

    public async Task<DnDCharacter> Read()
    {
        var characterJson = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "dndCharacter");
        if (string.IsNullOrWhiteSpace(characterJson))
        {
            return new();
        } ;
        return JsonSerializer.Deserialize<DnDCharacter>(characterJson) ?? new();
    }

    public async Task Delete()
    {
        await jsRuntime.InvokeAsync<string>("localStorage.removeItem", "dndCharacter");
    }
}