using ObjCRuntime;

namespace Binding
{
	[Native]
	public enum XRCPackageTypes : long
	{
		Unknown = -2,
		Custom = -1,
		Lifetime = 0,
		Annual = 1,
		SixMonth = 2,
		ThreeMonth = 3,
		TwoMonth = 4,
		Monthly = 5,
		Weekly = 6
	}
}
