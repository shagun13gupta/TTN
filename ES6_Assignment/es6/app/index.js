
import {circle,rectangle,cylinder} from './area'
import {outputArray} from './filtering'

/*Ques 1: Given this array: `[3,62,234,7,23,74,23,76,92]`, 
Using arrow function, create an array of the numbers greater than `70`*/

 const numbers = [3, 62, 234, 7, 23, 74, 23, 76, 92]; 
 var result = numbers.filter(number => number > 70); 
 console.log("Ques 1",result,"\n \n");
 


 /*Ques 2: <ul>
  <li data-time="5:17">Flexbox Video</li>
  <li data-time="8:22">Flexbox Video</li>
  <li data-time="3:34">Redux Video</li>
  <li data-time="5:23">Flexbox Video</li>
  <li data-time="7:12">Flexbox Video</li>
  <li data-time="7:24">Redux Video</li>
  <li data-time="6:46">Flexbox Video</li>
  <li data-time="4:45">Flexbox Video</li>
  <li data-time="4:40">Flexbox Video</li>
  <li data-time="7:58">Redux Video</li>
  <li data-time="11:51">Flexbox Video</li>
  <li data-time="9:13">Flexbox Video</li>
  <li data-time="5:50">Flexbox Video</li>
  <li data-time="5:52">Redux Video</li>
  <li data-time="5:49">Flexbox Video</li>
  <li data-time="8:57">Flexbox Video</li>
  <li data-time="11:29">Flexbox Video</li>
  <li data-time="3:07">Flexbox Video</li>
  <li data-time="5:59">Redux Video</li>
  <li data-time="3:31">Flexbox Video</li>
</ul>

a. Select all the list items on the page and convert to array.
b. Filter for only the elements that contain the word 'flexbox'
c. Map down to a list of time strings
d. Map to an array of seconds
e. Reduce to get total using .filter and .map */

//a. Select all the list items on the page and convert to array.

let items = document.getElementById("abc").querySelectorAll('li');  //get the html from index.html
let itemsArray=Array.from(items);    //converting into array
const arr=[];
for(var item of itemsArray)
 {
     arr.push(item.textContent);
    
    // console.log("3333333",item.textContent);
     
 }
console.log("Ques 2(a) ",arr,"\n");

console.log("\n");
//document.write(arr);


//b. Filter for only the elements that contain the word 'flexbox'

console.log("Ques 2(b)");
let flexItems= itemsArray.filter( (item) => item.innerText.includes('Flexbox'));

 for(var item of flexItems)
 {
     console.log(item);    
 }
 console.log("\n");


 //c. Map down to a list of time strings


 let finalArray=[];
 let listElements = document.getElementById("abc").getElementsByTagName("li");
 for(let element of listElements){
     finalArray.push( element.attributes[0].value)
 }
 console.log("Ques 2(c)",finalArray,"\n");
 console.log("\n");
 //d. Map to an array of seconds

  let secondsFinalArray=[];
  let finalSeconds;
  finalArray.map((time)=>{
     finalSeconds=  Number(time.split(":")[0]) *60 + Number(time.split(":")[1])
     secondsFinalArray.push(finalSeconds)
 })
 console.log("Ques 2(d)", secondsFinalArray,"\n");
 console.log("\n");
 //e. Reduce to get total using .filter and .map

 let totalTime=secondsFinalArray.reduce((total,num)=>{
    return total+num;
})
console.log("Ques 2(e)",totalTime,"\n");
console.log("\n");



/*Ques 3:  Create a markup template using string literal

const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};

 

Result:
"<div class="song">
   <p>
     Dying to live — Tupac
     (Featuring Biggie Smalls)
   </p>
 </div>“ */

 const song = {
    name: 'Dying to live',
    artist: 'Tupac',
    featuring: 'Biggie Smalls'
   };
   const literal = `<div class="song">
           <p>
               ${song.name} - ${song.artist}
               (Featuring ${song.featuring})
           </p>
       </div>`;
       console.log("Ques 3  "+literal,"\n"); 


/* Ques 4:  Extract all keys inside address object from user object using destructuring ?

const user = {
firstName: ‘Sahil’,
lastName: ‘Dua’,
Address: {
Line1: ‘address line 1’,
Line2: ‘address line 2’,
State: ‘Delhi’,
Pin: 110085,
Country: ‘India’,
City: ‘New Delhi’,
},
phoneNo: 9999999999
}*/

const user={
    firstName:"sahil",
    lastName:"Dua",
    Address:{
        Line1:'address line 1',
        Line2:'address line 2',
        State:'Delhi',
        Pin:110085,
        Country:'India',
        City:'New Delhi',
    },
    phoneNo:999999999
}
console.log("Ques 4(a) ",Object.keys(user.Address),"\n");
console.log("\n");


/*Ques 4(b):  Filter unique array members using Set.*/

let arr1=[19,20,19,21,76,21,98,45,21];
let res=new Set(arr1);
console.log("Ques 4(b)",res,"\n");
console.log("\n");


/*Ques 5: Find the possible combinations of a string and store them in a MAP? */

var letters = ["a", "b", "c"];
var combi = [];
var temp= "";
var finalMap=new Map();
var letLen = Math.pow(2, letters.length);

for (var i = 0; i < letLen ; i++){
    temp= "";
    for (var j=0;j<letters.length;j++) {
        if ((i & Math.pow(2,j))){ 
            temp += letters[j]
        }
    }
    if (temp !== "") {
        combi.push(temp);
    }
    finalMap.set(temp);   

}

console.log("Ques 5:",finalMap,"\n");
console.log("\n");
console.log("\n");

/*Ques 6: Write a program to implement inheritance upto 3 classes.
          The Class must  public variables and static functions.*/

console.log("Ques 6 \n");
class Shape
{
    constructor(name)
    {
         this.name=name;
    }
    static twodimension()
    {
        console.log("Two dimension Shape it is....");
    }
    show()
    {
        console.log("This is a Shape class");
    }
}
class Rectangle extends Shape
{
   constructor(sides)
   {   
       super(name);    
       this.sides=sides;
   }
   show()
   {
       console.log("This is a Rectangle class");
   }
}
class Hexagon extends Shape
{
    constructor(sides)
    {
        super(name);
        this.sides=sides;
    }
    show()
    {
        console.log("This is a Hexagon Class");
    }
}

let obj=new Rectangle(4);
obj.show();
Shape.twodimension();  //calling static function by class name because cant create object of static class
console.log("\n");
console.log("\n");

/* Ques 7: Write a program to implement a class having static functions */

class Mobile
{
    static show()
    {
        console.log("Ques 7    ","It is Mobile of Samsung Company","\n");
    }
}
Mobile.show(); //calling static function using class name.
console.log("\n");

/*Ques 8: Import a module containing the constants and method for 
          calculating area of circle, rectangle, cylinder.*/


       //imported from area.js   
console.log("Ques 8 : Area of circle with radii(4) is : " + circle(4));
console.log(" Area of rectangle with height(4) and breadth(5) is : " + rectangle(4,5));
console.log(" Area of cylinder with radiius(6) and height(10) is : " + cylinder(6,10));
console.log("\n");


/*Ques 9: Import a module for filtering unique elements in an array.*/

//imported from filtering.js.
console.log("Ques 9",outputArray,"\n");
console.log("\n");


/*Ques 10:Write a program to flatten a nested array to single level using arrow functions. */



var myArray = [[1, 2],[3, 4, 5], [6, 7, 8, 9]];
let flatter=()=>{
    var myNewArray3 = []; 
for (var i = 0; i < myArray.length; ++i) {
  for (var j = 0; j < myArray[i].length; ++j)
    myNewArray3.push(myArray[i][j]);
}
return myNewArray3;
}
console.log("Ques 10",flatter(),"\n");
console.log("\n");



/*Ques 11: Implement a singly linked list in es6 and implement
           addFirst() addLast(), length(), getFirst(), getLast(). (without using array)*/


           class LinkedList {
            constructor() {
              this.head = null;
              this.tail = null;
              this.count = 0;
            }
            
            get length() {
              return this.count;
            }
            
            addLast(data) {
              // Create a new Node
              const node = {
                data: data,
                next: null
              }
              
              if(this.count === 0) {
                // If this is the first Node, assign it to head
                this.head = node;
              } else {
                // If not the first node, link it to the last node
                this.tail.next = node;
              }
              
              this.tail = node;
              
              this.count++;
            }
            
            addFirst(data) {
              // Create a new Node
              const node = {
                data: data,
                next: null
              }
              
              // Save the first Node
              const temp = this.head;
              
              // Point head to the new Node
              this.head = node;
              
              // Add the rest of node behind the new first Node
              this.head.next = temp;
              
              this.count++;
              
              if(this.count === 1) {
                // If first node, 
                // point tail to it as well
                this.tail = this.head;
              }
            }            
             removeFirst() {
                if(this.count > 0) {
                    // The head should point to the second element
                    this.head = this.head.next;
                    
                    this.count--;  
                    
                    if(this.count === 0) {
                      // If list empty, set tail to null
                      this.tail = null;  
                    } 
                  }
             }  
  
          
          
          getFirst()
          {
            let getFirstNode=this.head;
            if(!this.head){
               console.log("Linked list is empty");
            }
            else{
               console.log("The first element of linked list is     " +getFirstNode.data);
                
            }
          }

          getLast()
          {
            let getLastNode=this.tail;
            if(!this.head){
               console.log("Linked list is empty");
            }
            else{
               console.log("The first element of linked list is     " +getLastNode.data);
                
            } 
          }
          listLength()
          {
            let counter = 0;
            let node = this.head;
            if(!this.head){
                console.log("Linked list is empty");
            }
            else{
                while(node.next!=null){
                    counter++;
                    node=node.next;
                    
                }
                counter+=1;
                console.log("The length of list is    "+counter);
            }
          }

          printList(){
            let curr = this.head;
            let out = [];
            while(curr !== null){
                if(curr.next === null){
                    out.push(curr.data);
                }else{
                    out.push(curr.data);
                    out.push("->")
                }
                curr = curr.next;
            }
            return out.join("");
        }

    }
    
      
    console.log("Ques 11\n\n");
          var linkedList = new LinkedList();
          linkedList.addLast(2);
          linkedList.addLast(19);
          linkedList.addFirst(1);         
          linkedList.addFirst(100);
          linkedList.addLast(4);
          linkedList.addFirst(45);
          linkedList.getFirst();
          linkedList.getLast();
          linkedList.listLength();           
          console.log(linkedList.printList());
          console.log("\n");
          console.log("\n");



/*Ques 12:Implement Map and Set using Es6 */



var map = new Map();  
    map.set('name', 'Shagun');  
    map.set('workplace', 'TTN');  
    map.set('address', 'New Delhi');  
    map.set('Phone', '9868940224');  
    console.log("Ques 12(a) using Map\n");
console.log(map);
console.log(map.get("name"));
console.log(map.size);  
console.log("\n");

console.log("Ques 12(b) using Set\n");
let colors = new Set(['Green', 'Red', 'Orange', 'Yellow', 'Red','Blue']);  
console.log(colors.size);  
console.log(colors);
console.log("\n");


/*Ques 13: Implementation of stack (using linked list) */


class Node{
    constructor(item, next = null){
        this.item = item,
        this.next = next
    }
}

//create a class for stack
class Stack{
    constructor(){
        this.top = null;
    }
    //Insert operation on stack
    push(item){
        let objstack=new Node(item);
        if(this.top){
            objstack.next=this.top;
            this.top=objstack;
        }
        else{
            this.top=objstack;
        }
    }
    //delete operation on stack
    pop() 
    {
        if( this.top ) {
          let itemToPop = this.top
          this.top = this.top.next
          //return itemToPop.data
        } 
        else {
          console.log("The stack is empty");
          return false;
        }
    }
    //return first element 

    peek() {
        if( this.top ) {
            console.log("Element at top of stack is;- "+this.top.item);
         
        } else {
            console.log("The stack is empty");
        }
    }
    //find length of stack
    length() {
        let current = this.top
        let counter = 0
        while( current ) {
         counter++
         current = current.next
        }
        console.log("The length of stack is  "+counter);
    }
    //dsiplay the whle stack
    traverse() 
    {
        if(this.top){
            var current = this.top; 
            var resultStack = current.item+" ,"; 
            while (current.next!=null) { 
                current = current.next; 
                resultStack += current.item + ","; 
            } 
            
            
            console.log("The resultent list is   "+ resultStack);
        }
        else{
            console.log("The stack is empty");   
        }

    }
}
console.log("Ques 13\n\n");
let stackobj=new Stack()
stackobj.push(7);
stackobj.push(9);
stackobj.pop();
stackobj.push(100);
stackobj.push(45);
stackobj.peek();
stackobj.pop();
stackobj.traverse();
stackobj.length();
