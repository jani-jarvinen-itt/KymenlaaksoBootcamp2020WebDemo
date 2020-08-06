import React from 'react';

interface TodoTila {
  otsikko: string;
}

class TodoKomponentti extends React.Component<{}, TodoTila> {

  constructor(props: any) {
    super(props);
    this.state = { otsikko: "(tyhjä)" };
  }

  componentDidMount() {

    const reactKomponetti = this;

    fetch('https://jsonplaceholder.typicode.com/todos/1')
      .then(response => response.json())
      .then(json => {
        console.log("Saatiin vastaus JSON-palvelusta:");
        console.log(json);

        reactKomponetti.setState({ otsikko: json.title });
      });
  }

  render() {
    return <div>
      <h1>Tämä on Todo-komponentti</h1>
      <p>Otsikko: {this.state.otsikko}</p>
    </div>;
  }
}

export default TodoKomponentti;
