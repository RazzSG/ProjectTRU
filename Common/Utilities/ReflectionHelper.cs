using System;
using System.Reflection;

namespace CalamityRuTranslate.Common.Utilities;

public static class ReflectionHelper
{
    public static BindingFlags UniversalFlags => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

    public static FieldInfo FindField(this Type type, string fieldName) => type.GetField(fieldName, UniversalFlags);

    public static PropertyInfo FindProperty(this Type type, string propertyName) => type.GetProperty(propertyName, UniversalFlags);

    public static ConstructorInfo FindConstructor(this Type type, params Type[] types) => type.GetConstructor(UniversalFlags, types);

    public static MethodInfo FindMethod(this Type type, string methodName) => type.GetMethod(methodName, UniversalFlags);

    public static MethodInfo FindMethod(this Type type, string methodName, Type[] types) => type.GetMethod(methodName, UniversalFlags, types);

    public static T GetMemberValue<T>(this object target, string memberName)
    {
        Type type = target as Type ?? target.GetType();
        object instance = target is Type ? null : target;
        
        FieldInfo field = type.FindField(memberName);
        if (field != null)
            return (T)field.GetValue(instance);
        
        PropertyInfo property = type.FindProperty(memberName);
        if (property != null)
            return (T)property.GetValue(instance);
        
        return default;
    }

    public static bool SetMemberValue(this object target, string memberName, object value)
    {
        Type type = target as Type ?? target.GetType();
        object instance = target is Type ? null : target;
        
        FieldInfo field = type.FindField(memberName);
        if (field != null)
        {
            field.SetValue(instance, value);
            return true;
        }
        
        PropertyInfo property = type.FindProperty(memberName);
        if (property != null)
        {
            property.SetValue(instance, value);
            return true;
        }
        
        return false;
    }
}