async function test() {
  await fetch("http://168.181.184.237:8080/api/usuario/test", { method: "GET" })
    .then((response) => response.json())
    .then((data) => {
      console.log(data);
    });
}

test();
