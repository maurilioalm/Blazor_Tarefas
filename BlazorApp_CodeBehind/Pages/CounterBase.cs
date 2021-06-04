using BlazorApp_CodeBehind.Servicos;
using Microsoft.AspNetCore.Components;

namespace BlazorApp_CodeBehind.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        [Inject] Servico1 servico1 { get; set; }

        protected void IncrementCount()
        {
            currentCount++;
            servico1.Valor = currentCount;
        }
    }
}
