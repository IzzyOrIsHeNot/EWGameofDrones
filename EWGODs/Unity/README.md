		<div>
			<h1 style="margin-top:20pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:20pt">
				<a name="_ly5xeiuhh6yu"></a>User Guide
			</h1>
			<p style="margin-top:0pt; margin-bottom:0pt">
				NOTE: The GUI is designed for the resolution: 1920x1200 and may not display properly on other configurations.
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; line-height:115%; font-size:16pt">
				<strong>Screen 1</strong>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">This screen allows the user to configure the dimensions of the drone cage being used. The dropdown menu contains saved cage configurations as well as the option to configure a new cage. Saved cage configurations are edit locked by default, but can be edited after clicking on the edit toggle. Click “Select” when ready to proceed with the currently selected cage configuration</span>
			</p>
			<h1 style="margin-top:20pt; margin-bottom:6pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				Screen 2
			</h1>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">This screen allows the user to configure the sensors being used. The uppermost dropdown menu allows the selection of existing sensors for modification or the selection of a new sensor. As sensor configuration data is modified, the user can see a visual representation of the sensor as well. Sensor data is not saved until the “Save” button is clicked. When satisfied with the configuration of all sensors, click the “Confirm” button.</span>
			</p>
			<h1 style="margin-top:20pt; margin-bottom:6pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				Screen 3
			</h1>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">This screen displays sensor pings to the user. The user will see ping objects appear and fade away when the sensors send ping data. </span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">If the ping contains some vertical position data (either do to a vertical component in the incoming ping or the sensor being configured to tilt up or down) then a number will appear next to the ping displaying the number of feet above or below the sensor the ping is at.</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">When this screen first opens, the GUI will attempt to connect to the Arduino Coordinator on COM 4. If the Arduino Coordinator is not connected to COM 4 (this can be checked in Device Manager), the user can attempt to connect or reconnect to the Arduino Coordinator by pressing a number key corresponding to the COM port to attempt connection with.</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; text-indent:36pt">
				<span style="font-family:'Times New Roman'">Pressing the ESCAPE key in this screen will return to the Sensor Placement screen. Pressing ESCAPE in any other screen will quit the application.</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<br style="page-break-before:always; clear:both" >
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; text-align:center; line-height:115%; font-size:20pt">
				<strong>Development Setup Guide</strong>
			</p>
			<ol type="1" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					Download and install <a href="https://unity.com/download" style="text-decoration:none"><u><span style="color:#0000ff">Unity</span></u></a>.
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					Download the GitHub Repository
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					In Unity Hub, click “Open” then “Add Project From Disk”
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					Navigate to the Unity folder in the downloaded repository and select it.
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					Open the project with Unity Hub
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					In the project, navigate to the “Game” tab
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					Open the “Free Aspect” tab and select “Target (1920x1200)”
				</li>
				<li style="margin-left:67.25pt; padding-left:4.75pt; font-family:'Times New Roman'">
					You are now ready to continue development of the Sensor Operator GUI
				</li>
			</ol>
			<p style="margin-top:0pt; margin-bottom:0pt; line-height:115%; font-size:20pt">
				&#xa0;
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<br style="page-break-before:always; clear:both" >
			</p>
			<h1 style="margin-top:20pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:20pt">
				Classes
			</h1>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_j045y31tkeeg"></a>Cage Configuration Setup
			</h2>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_8k8bv8dikivj"></a><span style="color:#434343">CageConfigDropdown : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Handles the user inputs in the cage configuration setup menu</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; line-height:normal; widows:0; orphans:0; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ValueChanged: UnityEvent</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">A UnityEvent allowing other classes to run code when the dropdown menu is changed</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">See </span><a href="https://docs.unity3d.com/ScriptReference/Events.UnityEvent.AddListener.html" style="text-decoration:none"><u><span style="font-family:'Times New Roman'; color:#1155cc">UnityEvent.AddListener()</span></u></a><span style="font-family:'Times New Roman'"> for how to listen for changes in the dropdown menu</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt; line-height:normal; widows:0; orphans:0">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; line-height:normal; widows:0; orphans:0; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">GetCurrentConfig(): CageConfiguration</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Returns current state of drone cage</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_93510gymikw0"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_fp23gb6nvcgu"></a><span style="color:#434343">Saver : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manages saving cage configurations for future runs of the application</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">static ForceSave(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Will save the data in the SaveState to the computer</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">GetState(): SaveState</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Returns a reference to the SaveState</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_lkuk7e4bl8l6"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_sf1trdpoppkb"></a><span style="color:#434343">SaveState</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Stores data in a manner allowing it to be saved to the computer for future runs of the application</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ConfigPrefabs: List&lt;CageConfiguration&gt;</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">List of cage configurations to save between runs of the application</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_cuhxrlfgcj7e"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_vk5zk0qryasl"></a><span style="color:#434343">CageConfiguration (struct)</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Holds the data necessary to construct a drone cage in the GUI</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">configName: string</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The name assigned to a cage</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">cageWidth: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The width of a cage </span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">cageLength: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The length of a cage. The length spans the blue team area and the red team area</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">sectorLength: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The length of a red team sector (aligned with the length of the cage)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">sectorCountX: uint</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The number of sectors along the length of the cage</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">sectorCountY: uint</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The number of sectors along the width of the cage</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_o9ofhwd6siul"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_omur7pl9eek7"></a><span style="color:#434343">Ruler : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manages and maintains a ruler graphic to the left and below the drone cage visual</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<span style="color:#434343">QuitConfirmation : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manages the quit confirmation sub-menu</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_6u4nti056od"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_j252lzve173z"></a><span style="color:#434343">CageRenderer : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Displays cage visual on screen.</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Provides mathematical support for finding coordinates on the screen</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">MAX_X: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The largest possible value of x the right side of the cage can reach on the current screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">MIN_X: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The smallest possible value of x the left side of the cage can reach on the current screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">MAX_Y: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The largest possible value of y the top side of the cage can reach on the current screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">MIN_Y: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The smallest possible value of y the bottom side of the cage can reach on the current screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">left: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The actual x position of the left side of the drone cage on the screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">right: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The actual x position of the right side of the drone cage on the screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">up: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The actual y position of the top side of the drone cage on the screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">down: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The actual y position of the bottom side of the drone cage on the screen</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">FeetToPixels(float feet): float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Converts a given value in feet to Unity units (not pixels as the name implies) by applying the scale of the drone cage visual</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_amjw9xnnzmtb"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_l1je2ykodshb"></a><span style="color:#434343">QuitListener : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Listens for ESC key press then quits the application</span>
				</li>
			</ul>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_qad5tebfy0aa"></a>&#xa0;
			</h2>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_6wvocptkmn7g"></a>User Input Validation
			</h2>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_1ympa7n90h4k"></a><span style="color:#434343">SensorDropdown : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manages the Sensor Selection Dropdown and edge cases related to it</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Mathods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">GetID(): uint</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Returns the sensor id of the currently selected sensor</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">AddNew(uint id): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Adds the sensor corresponding to the given id to the dropdown menu (unless it already exists) and sets dropdown menu to be at this option</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">DeleteID(uint id): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Deletes the option in the dropdown menu if it exists that corresponds with the sensor with the matching id</span><a name="_cagxumc0mtb0"></a>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">UpdateInputs(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Manually ensures the values in the user inputs match the selected sensor.</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-left:54pt; margin-bottom:0pt">
				<strong>&#xa0;</strong>
			</p>
			<p style="margin-top:0pt; margin-left:54pt; margin-bottom:0pt">
				<strong>&#xa0;</strong>
			</p>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_qmq5z47ypplz"></a><span style="color:#434343">AddingButton : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Adds a number (positive or negative) to a specific input field when clicked by the user</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_idcgv7no0usr"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_ngqad5hnqgdl"></a><span style="color:#434343">ConfirmButton : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Loads the Ping Display scene when the Confirm button is clicked</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_7qz1m8lpfj2m"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_gua7w9talvmz"></a><span style="color:#434343">abstract Constrainer : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Class that allows for code to run when an input field is modified in order to restrict the data in the input field to a set format</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_2de1kabiew9r"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_eo9tzplp8pl0"></a><span style="color:#434343">FloatConstrainer : Constrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains an input field’s data to be in a format that can be converted to the float data type</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_bawyu5mceybq"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_bl7wj42cl2aw"></a><span style="color:#434343">HAngleConstrainer : FloatConstrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains the horizontal rotation input field’s data to be in a format that can be converted to the float data type while remaining within the [0, 360) range</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_mk8ibfaahhz9"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_mr7f3ld6am4p"></a><span style="color:#434343">VAngleConstrainer : FloatConstrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains the vertical rotation input field’s data to be in a format that can be converted to the float data type while remaining within the [-90, 90] range</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_9rjjuvo59wv5"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_7nl6hnc4lh3t"></a><span style="color:#434343">PosFloatConstrainer : FloatConstrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains an input field’s data to be in a format that can be converted to the float data type while being positive</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_a6pnigtgetr4"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_prep73bk73ea"></a><span style="color:#434343">XConstrainer : PosFloatConstrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains the sensor x input field’s data to be in a format that can be converted to the float data type while being positive and not being larger than the length of the red team area of the drone cage in feet</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_o7apqyn5h2sr"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_41qnfl2xy90e"></a><span style="color:#434343">YConstrainer : PosFloatConstrainer</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Constrains the sensor y input field’s data to be in a format that can be converted to the float data type while being positive and not being larger than the width of the drone cage in feet</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_2ipfjnb2nwup"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_vaemv3vf34m"></a><span style="color:#434343">FloatParser : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Allows for reading of data in an input field into a float</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ReadField(): float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Reads the data in the input field as a float</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_9xosfn5xuekg"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_29tdhl2exy4t"></a><span style="color:#434343">IntParser : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Allows for reading of data in an input field into an integer</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ReadField(): int</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Reads the data in the input field as an integer</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_m1i2aijdxamr"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_c2d4zlrevjlw"></a><span style="color:#434343">TypeParser : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Allows for reading and setting the selected type of the Sensor Type dropdown menu</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ReadValue(): string</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Return the text of the currently selected sensor type dropdown menu option</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">SetValue(string text): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Set the currently selected sensor type dropdown menu option to match the given text (assuming the given text is an existing sensor type dropdown menu option)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">SetValue(uint index): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Set the currently selected sensor type dropdown menu option with the given index for the list of options</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_9a6ym6fpozzq"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_r2bjr2k7hsu3"></a><span style="color:#434343">VerticalRotationPreview : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Displays an indicator on screen corresponding with the vertical rotation input field</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_a6py1f2dt3po"></a>&#xa0;
			</h2>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_mdwyck2z8loy"></a>Sensor Management
			</h2>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_yohaa0i61k6z"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_wgji4rsny82l"></a><span style="color:#434343">SensorRenderer : MonoBehaviour</span>
			</h3>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Config: SensorConfiguration</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The configuration of the sensor the renderer is displaying</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">UpdateConfig(SensorConfiguration newConfig): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Gives the renderer a new config (or a changed version of an old config) and tells it to display it’s sensor visual to match</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_5zdwah5y6qxg"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_57d2oko8hrb5"></a><span style="color:#434343">SensorConfiguration</span>
			</h3>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">type: string</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The type of sensor being represented</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">id: uint</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The id of the sensor being represented</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">x: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The position of the sensor being represented in feet along the length of the drone cage from the left side of the red team’s area</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">y: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The position of the sensor being represented in feet along the width of the drone cage from the bottom side of the cage</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">hRotation: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The rotation of the sensor being represented horizontally in degrees where 0 degrees is facing towards the right side of the drone cage and rotating counter-clockwise increases the angle</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">vRotation: float</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">The rotation of the sensor being represented vertically in degrees where 0 degrees is pointing straight up, 90 degrees is facing parallel to the floor, etc.</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_1ycyre47clpk"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_yohka0vqvxux"></a><span style="color:#434343">SensorConfigReader : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Interface for reading data from user input</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ReadSensor(): SensorConfiguration</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Reads the user input fields and dropdowns into a SensorConfiguration object</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_8qu507rmlxyk"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_7kjyaz4f2p5h"></a><span style="color:#434343">SensorManager : MonoBehaviour</span>
			</h3>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">SaveSensor(uint id, SensorConfiguration newConfig): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Saving a sensor displays it visually with a specific id at a location constructed from a SensorConfiguration. Saving a sensor with an id another sensor was already saved with will overwrite the older sensor</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">DeleteSensor(uint id): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Deletes the sensor matching the given id if it exists.</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">FindSensor(uint id): SensorRenderer</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Returns the SenserRenderer (visual representation of sensor) corresponding with the given id if it exists. Will return null if no SensorRenderer matching the id was found</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">UpdateSensors(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Causes all visual sensors (SensorRenderers) to recalculate their positions/rotation/etc. on screen without changing their configuration. Useful when cage dimensions change.</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">GetSensors(): List&lt;SensorRenderer&gt;</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Returns a list of all SensorRenderers (visual representations of sensors) currently being managed.</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">HideSensor(uint id): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Disables the visual of the indicated sensor</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ShowAllSensors(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Enables the visuals of all sensors</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_pz4bpekdu7hp"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_sfgshfk92s0y"></a><span style="color:#434343">SensorPreview : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manages the preview display of the sensor currently being modified. This allows a real-time visual to update as the user changes the data making up the sensor’s position, rotation, and type</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">ResetPreview()</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Removes the sensor preview visual until user modifies inputs again</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_4j1if1b5bfsx"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_47ig7pij6lte"></a><span style="color:#434343">SensorDeleter : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Deletes the currently selected sensor when the Delete button is clicked by the user</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_qn8g9lekv5cx"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_8zs3d93h3dey"></a><span style="color:#434343">SensorSaver : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Saves the current user input as a sensor when the Save button is clicked by the user</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<p style="margin-top:0pt; margin-bottom:0pt; line-height:115%; font-size:14pt">
				<strong><span style="color:#434343">BackKeyListener : MonoBehaviour</span></strong>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:28.06pt; padding-left:7.94pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Returns to SensorPlacement scene when Escape key is pressed.</span>
				</li>
			</ul>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_b4k0eoyq5ky4"></a>&#xa0;
			</h2>
			<h2 style="margin-top:18pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_yxlnqsmcyv1k"></a>Ping Displaying
			</h2>
			<p style="margin-top:0pt; margin-bottom:0pt; line-height:115%; font-size:14pt">
				<strong><span style="color:#434343">COMSelector : MonoBehaviour</span></strong>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:28.06pt; padding-left:7.94pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Attached to same object as ArduinoListener</span>
				</li>
				<li style="margin-left:28.06pt; padding-left:7.94pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Reads number key input and attempts connection to an Arduino Coordinator on the corresponding COM port</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:28.06pt; padding-left:7.94pt; font-family:serif">
					<span style="font-family:'Times New Roman'">DefaultCom: int</span>
				</li>
				<li style="margin-left:28.06pt; padding-left:7.94pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Selects the default com port to attempt connection with</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_2l0j0b6a8sq9"></a><span style="color:#434343">ArduinoListener : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Reads input from the Coordinator Arduino and sends packets to corresponding sensor types</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_sitr4e60qv82"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_drbxxm24utu2"></a><span style="color:#434343">Jammer : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Handles Jam packets by causing large amounts of false positive pings on the GUI</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">DisplayJammed(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Creates large amounts of false positive pings when called</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_7dus6y4gybku"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_ujgd46yw5zg8"></a><span style="color:#434343">Sensor : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Parent class for all sensor types which handle displaying pings for different types of sensors</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">See SensorTemplate.cs for a template for adding custom sensors to the GUI</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Cage: CageRenderer (write only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Reference to the CageRenderer for calculations. Typically set when the Sensor is created</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">PingTemplate: GameObject (write only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Template GameObject for pings. Typically set when the Sensor is created</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Manager: SensorManager (write only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Manager of the sensors being displayed. Typically set when the Sensor is created</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Type: uint (read only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Id for the type of the sensor. For individual sensor types, expect this number to match the number in the first byte of ping packets from this type of sensor</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Methods</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">PlotPing(Ping ping): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Displays the provided ping object on the screen</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Jam(): void</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Generates fake pings for all sensors matching the type</span>
						</li>
					</ul>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_2jmxv2l1774f"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_keqbmqndb73b"></a><span style="color:#434343">LIDAR : Sensor</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Handles calculation of where on the screen to display pings from LIDAR sensors</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_c93c50mitk9l"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_oln78cylxupq"></a><span style="color:#434343">Ultrasonic : LIDAR</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Handles calculation of where on the screen to display pings from Ultrasonic sensors</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">LIDAR and Ultrasonic pings are calculated the same way so Ultrasonic uses the same code as LIDAR through inheritance</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_nm57ehkl5epq"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_mhy058b0xqa3"></a><span style="color:#434343">OMNISonic : Sensor</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Handles calculation of where on the screen to display pings from OMNISonic sensors</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_591y42p5rld6"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_n58xl6l3b3j2"></a><span style="color:#434343">PingFader : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Fades ping images out over time and eventually deletes them</span>
				</li>
			</ul>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_am0nxx9ztygc"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_i4iq964daemu"></a><span style="color:#434343">Ping</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Stores data from a ping packet</span>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Constructors</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Ping(string packet)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Creates a Ping object out of a packet received from the Arduino</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">Properties</span>
			</p>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">type: uint (read only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Number corresponding to the type of sensor the ping is from.</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">id: uint (read only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Number corresponding to the id of the sensor the ping is from</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">data: List&lt;string&gt; (read only)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">List of all data entries extracted from the packet received from the Arduino (except the type and id)</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_8d5dcnjhevpb"></a><span style="color:#434343">&#xa0;</span>
			</h3>
			<h3 style="margin-top:16pt; margin-bottom:4pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:14pt">
				<a name="_j1icr8paiitd"></a><span style="color:#434343">PingTextFader : MonoBehaviour</span>
			</h3>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Fades ping images out over time and eventually deletes them</span>
				</li>
			</ul>
		</div>
		<br style="page-break-before:always; clear:both; mso-break-type:section-break" >
		<div>
			<h1 style="margin-top:20pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:20pt">
				<a name="_xkpt0f84babg"></a>Scene Hierarchy
			</h1>
			<h2 style="margin-top:18pt; margin-bottom:6pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_jt23sf2luzcp"></a>CageConfig
			</h2>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Saver</span><span style="width:10.95pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has Saver.cs attached. Manages saving cage configurations between runs of the application)</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Canvas</span><span style="width:3.62pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(manages UI objects)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Side Panel</span><span style="width:25.26pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the visual of the panel on the side)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Main Panel</span><span style="width:21.59pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(visual panel covering the entire screen in the background</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Dropdown</span><span style="width:24.95pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has CageConfigDropdown.cs attached. Manages the dropdown for selecting cage configurations)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">EditToggleButton</span><span style="width:28.56pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(button that toggles the editability of user inputs when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Name Label</span><span style="width:17.95pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Name:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Name Input Field</span><span style="width:30.4pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the name of a cage configuration)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Length Label</span><span style="width:23.7pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Cage Length:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Length Input Field</span><span style="width:0.16pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="width:36pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the cage length of a cage)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Width Label</span><span style="width:27.36pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Cage Width:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Width Input Field</span><span style="width:3.82pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the cage width of a cage)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Length Label</span><span style="width:18.2pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Sector Length:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Length Input Field</span><span style="width:30.66pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the length of sectors in a cage configuration)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Count X Label</span><span style="width:11.77pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Sector Count X:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Count X Input Field</span><span style="width:24.23pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the number of sectors along the length of the cage)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Count Y Label</span><span style="width:11.77pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Sector Count Y:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sector Count Y Input Field</span><span style="width:24.23pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(input field for inputting the number of sectors along the width of the cage)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Save Button</span><span style="width:17.92pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(button that causes the current cage configuration to be saved)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Delete Button</span><span style="width:10.6pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(button that causes the current cage configuration to be deleted)</span>
						</li>
					</ul>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Select Button</span><span style="width:12.42pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(button that proceeds to the SensorPlacement scene with the current cage configuration selected)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Quit Confirmation</span><span style="width:26.42pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has QuitConfirmation.cs attached. the quit confirmation sub-menu. deactivated by default)</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Yes</span><span style="width:18.89pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the yes button. will quit when pressed)</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">No</span><span style="width:22.56pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the no button. will close the quit confirmation sub-menu when pressed)</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Quit Confirmation Message</span><span style="width:21.18pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the message asking the user if they are sure about quitting)</span>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Unit Message</span><span style="width:11.2pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays info message regarding units in the GUI)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Escape Note</span><span style="width:16.72pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays information about quitting by pressing ESC)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Drone Cage</span><span style="width:19.16pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has CageRenderer.cs attached. manages visual of the drone cage)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Vertical Sector Edge</span><span style="width:16.37pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines separating sectors in the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Edge</span><span style="width:24.05pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines forming the edges of the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Drone Starting Area</span><span style="width:18.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template object for the blue colored area in the cage visual)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Ruler</span><span style="width:11.56pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has Ruler.cs attached. manages the ruler visuals on the sides of the drone cage. will persist between scene changes)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Directional Light</span><span style="width:31.94pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(necessary to brighten ruler visual elements)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">RulerMark</span><span style="width:23.74pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(enabled by scripts. template visual component representing a single ruler mark)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">BottomRulerMain</span><span style="width:27.34pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(visual component of the main part of the bottom ruler)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">LeftRulerMain</span><span style="width:6.02pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(visual component of the main part of the left ruler)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">QuitListener</span><span style="width:16.4pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has QuitListener.cs attached. listens for ESC to be pressed then opens the quit confirmation sub-menu)</span>
				</li>
			</ul>
			<h2 style="margin-top:18pt; margin-bottom:6pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_iu8no97g009s"></a>SensorPlacement
			</h2>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Drone Cage</span><span style="width:19.16pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has CageRenderer.cs attached. manages visual of the drone cage)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Vertical Sector Edge</span><span style="width:16.37pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines separating sectors in the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Edge</span><span style="width:24.05pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines forming the edges of the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Drone Starting Area</span><span style="width:18.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template object for the blue colored area in the cage visual)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Canvas</span><span style="width:3.62pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(manages UI objects)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Side Panel</span><span style="width:25.26pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the visual of the panel on the side)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Main Panel</span><span style="width:21.59pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(visual panel covering the entire screen in the background</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Dropdown</span><span style="width:24.95pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorDropdown.cs attached. handles switching sensors via the dropdown menu)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Save Button</span><span style="width:17.92pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorSave.cs attached. handles a button that saves a sensor when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Delete Button</span><span style="width:10.6pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorDeleter.cs attached. manages a button that deletes a sensor when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Confirm Button</span><span style="width:2.03pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has ConfirmButton.cs attached. manages a button that swaps scenes to SensorReadings with saved sensors when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">ID Label</span><span style="width:32.6pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “ID:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">ID InputField</span><span style="width:11.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has IDConstrainer.cs and IntParser.cs attached. an input field for inputting the id of a sensor)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor X Label</span><span style="width:3.57pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Sensor X:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor X Input Field</span><span style="width:16.03pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has XConstrainer.cs and FloatParser.cs attached. an input field for inputting the X coordinate of a sensor)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor Y Label (text saying “Sensor Y:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor Y Input Field</span><span style="width:16.03pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has YConstrainer.cs and FloatParser.cs attached. an input field for inputting the Y coordinate of a sensor)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Horizontal Rotation Label</span><span style="width:28.53pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Horizontal Rotation:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Horizontal Rotation Input Field</span><span style="width:4.99pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has HAngleConstrainer.cs and FloatParser.cs attached. an input field for inputting the horizontal rotation of a sensor)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Vertical Rotation Label</span><span style="width:4.15pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Vertical Rotation:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Vertical Rotation Input Field</span><span style="width:16.61pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has VAngleConstrainer.cs and FloatParser.cs attached. an input field for inputting the vertical rotation of a sensor)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">-X Button</span><span style="width:27.69pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that decreases the value in Sensor X Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">+X Button</span><span style="width:25.15pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that increases the value in Sensor X Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">-Y Button</span><span style="width:27.69pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that decreases the value in Sensor Y Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">+Y Button</span><span style="width:25.15pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that increases the value in Sensor X Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">-HRotation Button</span><span style="width:25.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that decreases the value in Horizontal Rotation Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">+HRotation Button</span><span style="width:23.27pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that increases the value in Horizontal Rotation Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">-VRotation Button</span><span style="width:25.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has AddingButton.cs attached. a button that decreases the value in Vertical Rotation Input Field when clicked)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Type Label</span><span style="width:21.61pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(text saying “Sensor Type:”)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor Type Dropdown</span><span style="width:2.9pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has TypeParser.cs attached. a dropdown menu for selecting a sensor type)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Quit Confirmation</span><span style="width:26.42pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has QuitConfirmation.cs attached. the quit confirmation sub-menu. deactivated by default)</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Yes</span><span style="width:18.89pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the yes button. will quit when pressed)</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">No</span><span style="width:22.56pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the no button. will close the quit confirmation sub-menu when pressed)</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Quit Confirmation Message</span><span style="width:21.18pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the message asking the user if they are sure about quitting)</span>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Unit Message</span><span style="width:11.2pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays info message regarding units in the GUI)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Escape Note</span><span style="width:16.72pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays information about quitting by pressing ESC)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Sensors</span><span style="width:1.78pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="width:36pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorManager.cs attached. will persist between scene changes. manages sensors on screen)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor</span><span style="width:6.06pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorRenderer.cs attached. enabled by scripts. a single sensor visual)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">SensorPreview</span><span style="width:6.01pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has SensorPreview.cs attached. Manages the preview visual on screen)</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Vertical Rotation Indicator</span><span style="width:25.49pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has VerticalRotationPreview.cs attached. displays an indicator of the vertical rotation of the selected sensor)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Arrow</span><span style="width:7.29pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(the arrow that is pointed by the Vertical Rotation Indicator)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">QuitListener</span><span style="width:16.4pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has QuitListener.cs attached. listens for ESC to be pressed then opens the quit confirmation sub-menu)</span>
				</li>
			</ul>
			<h2 style="margin-top:18pt; margin-bottom:6pt; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:16pt">
				<a name="_tqfr7x5bd006"></a>SensorReadings
			</h2>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Drone Cage</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Vertical Sector Edge</span><span style="width:16.37pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines separating sectors in the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Edge</span><span style="width:24.05pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template for the lines forming the edges of the cage visual)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Drone Starting Area</span><span style="width:18.81pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template object for the blue colored area in the cage visual)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">PingManager</span><span style="width:12.74pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has ArduinoListener.cs and COMSelector.cs attached. displays pings corresponding to incoming packets from the coordinator Arduino)</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Ping</span><span style="width:15.83pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has PingFader.cs attached. is enabled by scripts. a visual element of a sensor ping)</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">BackKeyListener</span><span style="width:31.03pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(has BackButton.cs attacked. Listens for ESC key then manages return to Sensor Placement scene)</span>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Canvas</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Unit Message</span><span style="width:11.2pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays info message regarding units in the GUI)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Back Note</span><span style="width:25.27pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(displays that pressing ESC will return the GUI to the SensorPlacement scene)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Ping Height</span><span style="width:19.14pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(template object for the text that displays the height of pings in relation to their corresponding sensors. disabled by default. has PingTextFader.cs attached)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Failed Connection Message</span><span style="width:21.8pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(message signifying an unsuccessful connection attempt with the coordinator Arduino. disabled by default. has PingTextFader.cs attached)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Successful Connection Message</span><span style="width:2.25pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(message signifying a successful connection attempt with the coordinator Arduino. disabled by default. has PingTextFader.cs attached)</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">NoConnectionMessage</span><span style="width:5.35pt; font-family:'Times New Roman'; display:inline-block">&#xa0;</span><span style="font-family:'Times New Roman'">(message signifying no connection with the Arduino coordinator)</span>
						</li>
					</ul>
				</li>
			</ul>
			<p style="margin-top:0pt; margin-bottom:0pt">
				<span style="font-family:'Times New Roman'">&#xa0;</span>
			</p>
		</div>
		<br style="page-break-before:always; clear:both; mso-break-type:section-break" >
		<div>
			<h1 style="margin-top:20pt; margin-bottom:6pt; text-align:center; page-break-inside:avoid; page-break-after:avoid; line-height:115%; font-size:20pt">
				<a name="_stho1v31nert"></a><span style="font-weight:normal">Asset Hierarchy</span>
			</h1>
			<ul type="disc" style="margin:0pt; padding-left:0pt">
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Resources</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Images</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Arrow.png</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">LIDAR.png</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">OMNISonic.png</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">ping.png</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Protractor.png</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Ultrasonic.png</span>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Materials</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">CageEdge.mat</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">RulerMaterial.mat</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">SectorEdge.mat</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">QuitConfirmation.mat</span>
								</li>
							</ul>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Scenes</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">CageConfig.unity</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">SensorPlacement.unity</span>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">SensorReadings.unity</span>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Scripts</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Cage Configuration</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">CageConfigDropdown.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">CageRenderer.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">ConfigStorage.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Ruler.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Saver.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">SaveState.cs</span>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Ping Reading</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">ArduinoListener.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">LIDAR.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">OMNISonic.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Ping.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">PingFader.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Sensor.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">SensorTemplate.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Ultrasonic.cs</span>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Sensor Placement</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Sensor Management</span>
									<ul type="disc" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorConfigReader.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorConfiguration.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorDeleter.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorManager.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorPreview.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorSaver.cs</span>
										</li>
									</ul>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">User Input</span>
									<ul type="disc" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">AddingButton.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">ConfirmButton.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">Constrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">FloatConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">FloatParser.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">HAngleConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">IDConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">IntParser.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">PosFloatConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorDropdown.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">TypeParser.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">VAngleConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">XConstrainer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">YConstrainer.cs</span>
										</li>
									</ul>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">Visual Elements</span>
									<ul type="disc" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">SensorRenderer.cs</span>
										</li>
										<li style="margin-left:29.64pt; padding-left:6.36pt">
											<span style="font-family:'Times New Roman'">VerticalRotationPreview.cs</span>
										</li>
									</ul>
								</li>
							</ul>
						</li>
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">Quitting</span>
							<ul type="square" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">QuitListener.cs</span>
								</li>
								<li style="margin-left:29.64pt; padding-left:6.36pt">
									<span style="font-family:'Times New Roman'">QuitConfirmation.cs</span>
								</li>
							</ul>
						</li>
					</ul>
				</li>
				<li style="margin-left:29.64pt; padding-left:6.36pt; font-family:serif">
					<span style="font-family:'Times New Roman'">Application Icons</span>
					<ul type="circle" style="margin-right:0pt; margin-left:0pt; padding-left:0pt">
						<li style="margin-left:29.64pt; padding-left:6.36pt">
							<span style="font-family:'Times New Roman'">GameOfDronesLogo.png</span>
						</li>
					</ul>
				</li>
			</ul>
		</div>
	<p style="bottom: 10px; right: 10px; position: absolute;"><a href="https://wordtohtml.net" target="_blank" style="font-size:11px; color: #d0d0d0">Converted to HTML with WordToHTML.net</a></p>