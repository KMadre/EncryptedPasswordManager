﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/PasswordSchema.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/PasswordSchema.xsd", IsNullable=false)]
public partial class SaveFileData {
    
    private SaveFileDataLoginCredentials loginCredentialsField;
    
    private SaveFileDataPasswordItem[] passwordItemsField;
    
    /// <remarks/>
    public SaveFileDataLoginCredentials LoginCredentials {
        get {
            return this.loginCredentialsField;
        }
        set {
            this.loginCredentialsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("PasswordItem", IsNullable=false)]
    public SaveFileDataPasswordItem[] PasswordItems {
        get {
            return this.passwordItemsField;
        }
        set {
            this.passwordItemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/PasswordSchema.xsd")]
public partial class SaveFileDataLoginCredentials {
    
    private string usernameField;
    
    private string passwordField;
    
    /// <remarks/>
    public string Username {
        get {
            return this.usernameField;
        }
        set {
            this.usernameField = value;
        }
    }
    
    /// <remarks/>
    public string Password {
        get {
            return this.passwordField;
        }
        set {
            this.passwordField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/PasswordSchema.xsd")]
public partial class SaveFileDataPasswordItem {
    
    private SaveFileDataPasswordItemPasswordData passwordDataField;
    
    private bool isHashedField;
    
    private bool isDoubleProtectedField;
    
    private string linkField;
    
    private string doublePasswordField;
    
    /// <remarks/>
    public SaveFileDataPasswordItemPasswordData PasswordData {
        get {
            return this.passwordDataField;
        }
        set {
            this.passwordDataField = value;
        }
    }
    
    /// <remarks/>
    public bool isHashed {
        get {
            return this.isHashedField;
        }
        set {
            this.isHashedField = value;
        }
    }
    
    /// <remarks/>
    public bool isDoubleProtected {
        get {
            return this.isDoubleProtectedField;
        }
        set {
            this.isDoubleProtectedField = value;
        }
    }
    
    /// <remarks/>
    public string Link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    public string DoublePassword {
        get {
            return this.doublePasswordField;
        }
        set {
            this.doublePasswordField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/PasswordSchema.xsd")]
public partial class SaveFileDataPasswordItemPasswordData {
    
    private string usernameField;
    
    private string passwordField;
    
    private string keyField;
    
    private string ivField;
    
    /// <remarks/>
    public string Username {
        get {
            return this.usernameField;
        }
        set {
            this.usernameField = value;
        }
    }
    
    /// <remarks/>
    public string Password {
        get {
            return this.passwordField;
        }
        set {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    public string Key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    public string Iv {
        get {
            return this.ivField;
        }
        set {
            this.ivField = value;
        }
    }
}
