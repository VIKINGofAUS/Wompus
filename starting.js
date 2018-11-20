

function thisIsAFunction(i) {
    fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => console.log(json))
        //const myJson = await response.json(); //extract JSON from the http response
        // do something with myJson
//       }  

// const userAction = async () => {
//     const response = await fetch('http://example.com/movies.json', {
//       method: 'POST',
//       body: "myBody", // string or object
//       headers:{
//         'Content-Type': 'application/json'
//       }
//     });
//     const myJson = await response.json(); //extract JSON from the http response
//     // do something with myJson
//     console.log(myJson)
//   }
//console.log(myJson)
  
}