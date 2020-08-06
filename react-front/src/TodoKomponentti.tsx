import React from 'react';

interface TodoTila {
  otsikko: string;
}

class TodoKomponentti extends React.Component<{}, TodoTila> {

  constructor(props: any) {
    super(props);
    this.state = { otsikko: "(tyhjä)" };
  }

  render() {
    return <div>
      <h1>Tämä on Todo-komponentti</h1>
      <p>Otsikko: {this.state.otsikko}</p>
    </div>;
  }
}

export default TodoKomponentti;
