using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSE.Net.Layouts.Fortaleza
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://iss.fortaleza.ce.gov.br/grpfor-iss/ServiceGinfesImplService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://iss.fortaleza.ce.gov.br/grpfor-iss/ServiceGinfesImplService", IsNullable = false)]
    public class CancelarNfseEnvio
    {

        private tcPedidoCancelamento pedidoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public tcPedidoCancelamento Pedido
        {
            get
            {
                return this.pedidoField;
            }
            set
            {
                this.pedidoField = value;
            }
        }
    }
}
