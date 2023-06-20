using System.Reflection;

namespace BrightIdeasSoftware;

public static class TypeExts
{
	public static FieldInfo? GetFieldByMultipleNames(this Type t, BindingFlags bindingFlags, params string[] names)
	{
		foreach (var name in names)
		{
			var field = t.GetField(name, bindingFlags);
			if (field != null)
				return field;
		}
		return null;
	}
}
