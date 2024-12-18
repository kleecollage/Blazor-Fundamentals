using Microsoft.AspNetCore.Components;

namespace Fundamentals.Components.Pages;

public partial class ListElements: ComponentBase
{
    private List<String> elements = new();
    private string newElement;

    private void AddElements()
    {
        if (!string.IsNullOrEmpty(newElement))
        {
            elements.Add(newElement);
            newElement = string.Empty;
        }
    }
}