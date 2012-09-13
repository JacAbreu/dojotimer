using System;
using System.Collections.Generic;
using System.Text;

namespace DojoTimer.Helpers
{
    public class PostTemplate
    {

        String dojoLocal;

        String dojoTheme;

        String dojoSource;

        String dojoFacts;

        String dojoResume;

        public PostTemplate(string local, string subject, string source, string dojoFacts, string dojoResume)
        {
            this.dojoFacts = dojoFacts;
            this.dojoResume = dojoResume;
            this.dojoSource = source;
            this.dojoTheme = subject;
            this.dojoLocal = local;
        }

        public StringBuilder postTemplateToPublish(PostTemplate postTemplateInstance)
        {
            StringBuilder postDojoResume = new StringBuilder();

            postDojoResume.Append("Boa noite, pessoas. O dojo de hoje terminou agora :D");

            if (postTemplateInstance.dojoTheme.Length > 0)
            {
                postDojoResume.Append("O tema do dojo de hoje foi");
                postDojoResume.Append(postTemplateInstance.dojoTheme);
            }
            if (postTemplateInstance.dojoSource.Length > 0)
            {
                postDojoResume.Append("O problema de hoje pode ser encontrado em ");
                postDojoResume.Append(postTemplateInstance.dojoSource);
            }

            postDojoResume.Append(postTemplateInstance.dojoResume);

            if (postTemplateInstance.dojoFacts.Length > 0)
            {
                postDojoResume.Append("E como facts, tivemos: ");
                postDojoResume.Append(postTemplateInstance.dojoFacts);
            }


            return postDojoResume;
        }


    }
}
