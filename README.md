<h1>GridView with Sticky Header</h1>

<p>This is a simple ASP.NET WebForms project that demonstrates how to create a <code>GridView</code> with a sticky header using HTML and CSS. The GridView allows the user to scroll through the content while keeping the header fixed at the top.</p>

<h2>Features</h2>
<ul>
    <li>Sticky header for a <code>GridView</code> that remains visible during vertical scrolling.</li>
    <li>Simple design with fixed-width columns for uniformity.</li>
    <li>Scrollable table content with a maximum height defined for the GridView.</li>
    <li>Zebra striping and hover effects for improved readability and interaction.</li>
</ul>

<h2>Table of Contents</h2>
<ul>
    <li><a href="#installation">Installation</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#customization">Customization</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
</ul>

<h2 id="installation">Installation</h2>
<ol>
    <li>Clone the repository:
        <pre><code>git clone https://github.com/S-M-A-T/GridView-Sticky-Header.git</code></pre>
    </li>
    <li>Open the project in Visual Studio.</li>
    <li>Build and run the project.</li>
    <li>Navigate to the <code>Default.aspx</code> page to see the sticky header in action.</li>
</ol>

<h2 id="usage">Usage</h2>
<p>The sample data is generated dynamically in the <code>BindGrid</code> method in the code-behind file (<code>Default.aspx.cs</code>). You can replace this sample data with your actual data source.</p>
<p>The project uses inline CSS to define the sticky header and table layout. The <code>GridView</code> is placed inside a container with a scrollable area, ensuring that the content can be scrolled while the header remains fixed.</p>

<h2 id="customization">Customization</h2>
<p>To modify the appearance or functionality of the GridView:</p>
<ol>
    <li><strong>Change GridView content:</strong> Update the <code>BindGrid</code> method in <code>Default.aspx.cs</code> to pull data from your own data source.</li>
    <li><strong>Adjust table height:</strong> Modify the <code>max-height</code> property in the <code>.grid-container</code> CSS class to change the height of the scrollable area.</li>
    <li><strong>Modify styles:</strong> Update the CSS in the <code>&lt;style&gt;</code> block inside <code>Default.aspx</code> to customize the table’s appearance (e.g., colors, padding, borders).</li>
    <li><strong>Columns:</strong> Add or remove columns in the <code>asp:GridView</code> control by adding or removing <code>asp:BoundField</code> elements inside the <code>&lt;Columns&gt;</code> section in <code>Default.aspx</code>.</li>
</ol>

<h2 id="contributing">Contributing</h2>
<p>Contributions are welcome! If you'd like to contribute to this project:</p>
<ol>
    <li>Fork the repository.</li>
    <li>Create a new branch with your feature or bug fix.</li>
    <li>Commit your changes.</li>
    <li>Push the branch and create a Pull Request.</li>
</ol>

<h2 id="license">License</h2>
<p>This project is licensed under the MIT License. See the <code>LICENSE</code> file for more details.</p>
