How to run this?

Way 1:
Copy this dll to webapplication bin direcotry
Add the below entry in the application web.config

<modules>
          <add name="HttpModule" type="ExHTTPModule.Module, ExHTTPModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9d7490a46e3a39df" />
</modules>


Way 2:
Add this assembly to GAC
In IIS Navigate to Your website >Modules 
Right hand side click on 'Add Managed Module'
Specify the type as "ExHTTPModule.Module, ExHTTPModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9d7490a46e3a39df"