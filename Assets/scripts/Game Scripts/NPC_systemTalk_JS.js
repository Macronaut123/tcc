	private var talking:boolean;
	private var currentLine:int;
	private var textIsScrolling:boolean;
	
 	var talkLines:String[];
	var talkTextGUI:GUIText;
	var scrollSpeed:int;
	
	function OnTriggerEnter(hit:Collider){
	
		if(hit.tag == "Player"){
		
			talking = true;
			currentLine = 0;
			//talkTextGUI.text = talkLines[currentLine];
			
			startScrolling();
		}
	}
	
	function Update () {
	
		if(talking){ 
			if(Input.GetKeyDown(KeyCode.PageDown)){
				if(textIsScrolling){
					talkTextGUI.text = talkLines[currentLine];
					textIsScrolling = false;
				}else{
					if(currentLine < talkLines.Length - 1){
						currentLine++;
						startScrolling();
					}else{
						currentLine = 0;
						talkTextGUI.text = "";
						talking = false;
					}
				}
			}
		}
	}
	
	function startScrolling(){
		
		textIsScrolling = true;
		
		var displayText:String = "";
		var startLine:int = currentLine;
		
		for(var i:int = 0; i < talkLines[currentLine].Length; i++){
		
			if(textIsScrolling && currentLine == startLine){
			
				displayText += talkLines[currentLine][i];
				talkTextGUI.text = displayText;
				
				yield WaitForSeconds(1 / scrollSpeed);
			}else{
				return;
			}
		}
		
		textIsScrolling = false;
	}
