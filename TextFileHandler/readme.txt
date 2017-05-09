How to run this?

Copy this dll to webapplication bin direcotry
from iis HTTP handlers map this to *.snp file extension (some dummy extension as mapping to .txt was overriden)
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