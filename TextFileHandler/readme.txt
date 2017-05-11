How to run this?
Way 1:
Copy this dll to webapplication bin direcotry
from IIS HTTP handlers map this to *.snp file extension (some dummy extension as mapping to .txt was overriden)
only when there is a .snp file in the directory this handler works.

It adds this entry in web.config automatically
 <system.webServer>
    <modules>
      <remove name="FormsAuthenticationModule" />
    </modules>
        <handlers>
            <add name="TextFileHandler" path="*.snp" verb="*" type="TextFileHandler.TxtHandler" resourceType="File" preCondition="integratedMode" />
        </handlers>
  </system.webServer>



  Way 2:

  Add this assembly to GAC using gacutil.exe (get from developer command prompt)
  In IIS >Your Website >Handler Mappings >Add managed handler reigster this assembly
  Type should be specified as "TextFileHandler.TxtHandler,TextFileHandler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0ea1c40667eeada1"
  Every request to *.snp file will be handled by this handler.
  This adds the below entry in web.config
  <system.webServer>
    <modules>
      <remove name="FormsAuthenticationModule" />
    </modules>
        <handlers>
            <add name="TextFileHandler" path="*.snp" verb="*" type="TextFileHandler.TxtHandler,TextFileHandler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0ea1c40667eeada1" resourceType="File" preCondition="integratedMode" />
        </handlers>
  </system.webServer>
  <runtime>