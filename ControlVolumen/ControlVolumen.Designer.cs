namespace ControlVolumen
{
    partial class ControlVolumen
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ControlVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ControlVolumen";
            this.Size = new System.Drawing.Size(400, 200);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ControlVolumen_Layout);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ControlVolumen_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlVolumen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlVolumen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlVolumen_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
