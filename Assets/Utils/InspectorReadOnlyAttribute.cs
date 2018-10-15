//InspectorReadOnlyAttributeDrawer by SVerde
//contact@sverdegd.com
//https://github.com/sverdegd

using UnityEngine;

public class InspectorReadOnlyAttribute : PropertyAttribute
{
    public string labelOverride = string.Empty;

    public InspectorReadOnlyAttribute()
    {

    }

    public InspectorReadOnlyAttribute(string labelOverride)
    {
        this.labelOverride = labelOverride;
    }
}
