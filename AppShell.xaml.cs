// Die Shell organisiert die Navigation der App.
// Sie definiert die Navigationsstruktur und ermöglicht es, zwischen verschiedenen Seiten zu navigieren.
// Sie ist nicht gleichbedeutend mit dem Dashboard, dieses würde eine eigenständige Page bekommen,
// deren Inhalt und verlinkungen wiederum in der Shell definiert werden würden

namespace TrainMe;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
}
