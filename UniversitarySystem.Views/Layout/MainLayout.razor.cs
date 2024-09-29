using Microsoft.AspNetCore.Components.Web;

namespace UniversitarySystem.Views.Layout
{
    public partial class MainLayout
    {
        ErrorBoundary ErrorBoundaryRef;

        void Recover() => ErrorBoundaryRef?.Recover();
    }
}