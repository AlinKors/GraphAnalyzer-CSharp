
namespace GraphAnalyzer
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generation_Graph = new MaterialSkin.Controls.MaterialButton();
            this.createParse = new MaterialSkin.Controls.MaterialButton();
            this.countVertex = new MaterialSkin.Controls.MaterialTextBox();
            this.mandatiryButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.mixedButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.countEdge = new MaterialSkin.Controls.MaterialTextBox();
            this.linkFail = new MaterialSkin.Controls.MaterialTextBox();
            this.countEdgeRole = new MaterialSkin.Controls.MaterialTextBox();
            this.countVertexRole = new MaterialSkin.Controls.MaterialTextBox();
            this.linkFailRole = new MaterialSkin.Controls.MaterialTextBox();
            this.roleButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.CheckMLS = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // Generation_Graph
            // 
            this.Generation_Graph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Generation_Graph.Depth = 0;
            this.Generation_Graph.DrawShadows = true;
            this.Generation_Graph.HighEmphasis = true;
            this.Generation_Graph.Icon = null;
            this.Generation_Graph.Location = new System.Drawing.Point(265, 178);
            this.Generation_Graph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Generation_Graph.MouseState = MaterialSkin.MouseState.HOVER;
            this.Generation_Graph.Name = "Generation_Graph";
            this.Generation_Graph.Size = new System.Drawing.Size(159, 36);
            this.Generation_Graph.TabIndex = 0;
            this.Generation_Graph.Text = "Генерация графа";
            this.Generation_Graph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Generation_Graph.UseAccentColor = false;
            this.Generation_Graph.UseVisualStyleBackColor = true;
            this.Generation_Graph.Click += new System.EventHandler(this.Generation_Graph_Click);
            // 
            // createParse
            // 
            this.createParse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createParse.Depth = 0;
            this.createParse.DrawShadows = true;
            this.createParse.HighEmphasis = true;
            this.createParse.Icon = null;
            this.createParse.Location = new System.Drawing.Point(274, 298);
            this.createParse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createParse.MouseState = MaterialSkin.MouseState.HOVER;
            this.createParse.Name = "createParse";
            this.createParse.Size = new System.Drawing.Size(131, 36);
            this.createParse.TabIndex = 1;
            this.createParse.Text = "создать граф";
            this.createParse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createParse.UseAccentColor = false;
            this.createParse.UseVisualStyleBackColor = true;
            this.createParse.Click += new System.EventHandler(this.createParse_Click);
            // 
            // countVertex
            // 
            this.countVertex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countVertex.Depth = 0;
            this.countVertex.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countVertex.Hint = "количество вершин";
            this.countVertex.Location = new System.Drawing.Point(47, 152);
            this.countVertex.MaxLength = 50;
            this.countVertex.MouseState = MaterialSkin.MouseState.OUT;
            this.countVertex.Multiline = false;
            this.countVertex.Name = "countVertex";
            this.countVertex.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.countVertex.Size = new System.Drawing.Size(177, 36);
            this.countVertex.TabIndex = 2;
            this.countVertex.Text = "";
            this.countVertex.UseTallSize = false;
            // 
            // mandatiryButton
            // 
            this.mandatiryButton.AutoSize = true;
            this.mandatiryButton.Checked = true;
            this.mandatiryButton.Depth = 0;
            this.mandatiryButton.Location = new System.Drawing.Point(47, 95);
            this.mandatiryButton.Margin = new System.Windows.Forms.Padding(0);
            this.mandatiryButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mandatiryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mandatiryButton.Name = "mandatiryButton";
            this.mandatiryButton.Ripple = true;
            this.mandatiryButton.Size = new System.Drawing.Size(146, 37);
            this.mandatiryButton.TabIndex = 3;
            this.mandatiryButton.TabStop = true;
            this.mandatiryButton.Text = "Мандатная ПБ";
            this.mandatiryButton.UseVisualStyleBackColor = true;
            // 
            // mixedButton
            // 
            this.mixedButton.AutoSize = true;
            this.mixedButton.Depth = 0;
            this.mixedButton.Location = new System.Drawing.Point(257, 95);
            this.mixedButton.Margin = new System.Windows.Forms.Padding(0);
            this.mixedButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mixedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mixedButton.Name = "mixedButton";
            this.mixedButton.Ripple = true;
            this.mixedButton.Size = new System.Drawing.Size(148, 37);
            this.mixedButton.TabIndex = 4;
            this.mixedButton.TabStop = true;
            this.mixedButton.Text = "Смешанная ПБ";
            this.mixedButton.UseVisualStyleBackColor = true;
            // 
            // countEdge
            // 
            this.countEdge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countEdge.Depth = 0;
            this.countEdge.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countEdge.Hint = "количество ребер";
            this.countEdge.Location = new System.Drawing.Point(47, 208);
            this.countEdge.MaxLength = 50;
            this.countEdge.MouseState = MaterialSkin.MouseState.OUT;
            this.countEdge.Multiline = false;
            this.countEdge.Name = "countEdge";
            this.countEdge.Size = new System.Drawing.Size(177, 36);
            this.countEdge.TabIndex = 5;
            this.countEdge.Text = "";
            this.countEdge.UseTallSize = false;
            // 
            // linkFail
            // 
            this.linkFail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkFail.Depth = 0;
            this.linkFail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkFail.Hint = "Путь к файлу txt...";
            this.linkFail.Location = new System.Drawing.Point(47, 299);
            this.linkFail.MaxLength = 50;
            this.linkFail.MouseState = MaterialSkin.MouseState.OUT;
            this.linkFail.Multiline = false;
            this.linkFail.Name = "linkFail";
            this.linkFail.Size = new System.Drawing.Size(177, 36);
            this.linkFail.TabIndex = 6;
            this.linkFail.Text = "";
            this.linkFail.UseTallSize = false;
            // 
            // countEdgeRole
            // 
            this.countEdgeRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countEdgeRole.Depth = 0;
            this.countEdgeRole.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countEdgeRole.Hint = "количество ребер";
            this.countEdgeRole.Location = new System.Drawing.Point(466, 207);
            this.countEdgeRole.MaxLength = 50;
            this.countEdgeRole.MouseState = MaterialSkin.MouseState.OUT;
            this.countEdgeRole.Multiline = false;
            this.countEdgeRole.Name = "countEdgeRole";
            this.countEdgeRole.Size = new System.Drawing.Size(177, 36);
            this.countEdgeRole.TabIndex = 7;
            this.countEdgeRole.Text = "";
            this.countEdgeRole.UseTallSize = false;
            // 
            // countVertexRole
            // 
            this.countVertexRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countVertexRole.Depth = 0;
            this.countVertexRole.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countVertexRole.Hint = "количество вершин";
            this.countVertexRole.Location = new System.Drawing.Point(466, 152);
            this.countVertexRole.MaxLength = 50;
            this.countVertexRole.MouseState = MaterialSkin.MouseState.OUT;
            this.countVertexRole.Multiline = false;
            this.countVertexRole.Name = "countVertexRole";
            this.countVertexRole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.countVertexRole.Size = new System.Drawing.Size(177, 36);
            this.countVertexRole.TabIndex = 8;
            this.countVertexRole.Text = "";
            this.countVertexRole.UseTallSize = false;
            // 
            // linkFailRole
            // 
            this.linkFailRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkFailRole.Depth = 0;
            this.linkFailRole.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkFailRole.Hint = "Путь к файлу txt...";
            this.linkFailRole.Location = new System.Drawing.Point(466, 298);
            this.linkFailRole.MaxLength = 50;
            this.linkFailRole.MouseState = MaterialSkin.MouseState.OUT;
            this.linkFailRole.Multiline = false;
            this.linkFailRole.Name = "linkFailRole";
            this.linkFailRole.Size = new System.Drawing.Size(177, 36);
            this.linkFailRole.TabIndex = 9;
            this.linkFailRole.Text = "";
            this.linkFailRole.UseTallSize = false;
            // 
            // roleButton
            // 
            this.roleButton.AutoSize = true;
            this.roleButton.Depth = 0;
            this.roleButton.Location = new System.Drawing.Point(479, 95);
            this.roleButton.Margin = new System.Windows.Forms.Padding(0);
            this.roleButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.roleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.roleButton.Name = "roleButton";
            this.roleButton.Ripple = true;
            this.roleButton.Size = new System.Drawing.Size(123, 37);
            this.roleButton.TabIndex = 10;
            this.roleButton.TabStop = true;
            this.roleButton.Text = "Ролевая ПБ";
            this.roleButton.UseVisualStyleBackColor = true;
            // 
            // CheckMLS
            // 
            this.CheckMLS.AutoSize = true;
            this.CheckMLS.Depth = 0;
            this.CheckMLS.Location = new System.Drawing.Point(257, 238);
            this.CheckMLS.Margin = new System.Windows.Forms.Padding(0);
            this.CheckMLS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckMLS.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckMLS.Name = "CheckMLS";
            this.CheckMLS.Ripple = true;
            this.CheckMLS.Size = new System.Drawing.Size(167, 37);
            this.CheckMLS.TabIndex = 11;
            this.CheckMLS.Text = "Проверка на MLS";
            this.CheckMLS.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 369);
            this.Controls.Add(this.CheckMLS);
            this.Controls.Add(this.roleButton);
            this.Controls.Add(this.linkFailRole);
            this.Controls.Add(this.countVertexRole);
            this.Controls.Add(this.countEdgeRole);
            this.Controls.Add(this.linkFail);
            this.Controls.Add(this.countEdge);
            this.Controls.Add(this.mixedButton);
            this.Controls.Add(this.mandatiryButton);
            this.Controls.Add(this.countVertex);
            this.Controls.Add(this.createParse);
            this.Controls.Add(this.Generation_Graph);
            this.Name = "Menu";
            this.Text = "GraphAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Generation_Graph;
        private MaterialSkin.Controls.MaterialButton createParse;
        private MaterialSkin.Controls.MaterialTextBox countVertex;
        private MaterialSkin.Controls.MaterialRadioButton mandatiryButton;
        private MaterialSkin.Controls.MaterialRadioButton mixedButton;
        private MaterialSkin.Controls.MaterialTextBox countEdge;
        private MaterialSkin.Controls.MaterialTextBox linkFail;
        private MaterialSkin.Controls.MaterialTextBox countEdgeRole;
        private MaterialSkin.Controls.MaterialTextBox countVertexRole;
        private MaterialSkin.Controls.MaterialTextBox linkFailRole;
        private MaterialSkin.Controls.MaterialRadioButton roleButton;
        private MaterialSkin.Controls.MaterialCheckbox CheckMLS;
    }
}

