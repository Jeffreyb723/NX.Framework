using NXOpen;
using NXOpen.Assemblies;

namespace NX.Framework
{
    public static class NxObjectExtensions
    {
        public static void SetUserIntegerAttribute(this NXObject nxObject, string title, int value) =>
            nxObject.SetUserAttribute(title, -1, value, Update.Option.Now);
        public static int GetUserIntegerAttribute(this NXObject nxObject, string title) =>
            nxObject.GetUserAttribute(title, NXObject.AttributeType.Integer, -1).IntegerValue;
        public static bool HasUserIntegerAttribute(this NXObject nxObject, string title) =>
            nxObject.HasUserAttribute(title, NXObject.AttributeType.Integer, -1);

        public static void SetUserBooleanAttribute(this NXObject nxObject, string title, bool value) =>
            nxObject.SetBooleanUserAttribute(title, -1, value, Update.Option.Now);
        public static bool GetUserBooleanAttribute(this NXObject nxObject, string title) =>
            nxObject.GetUserAttribute(title, NXObject.AttributeType.Boolean, -1).BooleanValue;
        public static bool HasUserBooleanAttribute(this NXObject nxObject, string title) =>
            nxObject.HasUserAttribute(title, NXObject.AttributeType.Boolean, -1);

        public static void SetUserStringAttribute(this NXObject nxObject, string title, string value) =>
            nxObject.SetUserAttribute(title, -1, value, Update.Option.Now);
        public static string GetUserStringAttribute(this NXObject nxObject, string title) =>
            nxObject.GetUserAttribute(title, NXObject.AttributeType.Any, -1).StringValue;
        public static bool HasUserStringAttribute(this NXObject nxObject, string title) =>
            nxObject.HasUserAttribute(title, NXObject.AttributeType.Any, -1);

        public static void SetInstanceUserStringAttribute(this Component component, string title, string value) =>
            component.SetUserAttribute(title, -1, value, Update.Option.Now);
        public static string GetInstanceUserStringAttribute(this Component component, string title) =>
            component.GetInstanceUserAttribute(title, NXObject.AttributeType.Any, -1).StringValue;
        public static bool HasInstanceUserStringAttribute(this Component component, string title) =>
            component.HasInstanceUserAttribute(title, NXObject.AttributeType.Any, -1);
    }
}
