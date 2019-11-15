class Main extends React.Component {
    const data = [
        { Id: 1, Author: 'Daniel Lo Nigro', Text: 'Hello ReactJS.NET World!' },
        { Id: 2, Author: 'Pete Hunt', Text: 'This is one comment' },
        { Id: 3, Author: 'Jordan Walke', Text: 'This is *another* comment' },
    ];

    render() {
        return (
            <div>
                <div className="row">
                    <div className="jumbotron">
                        <h1 className="display-3">Hello, world!</h1>
                        <p className="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
                        <hr className="my-4" />
                        <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
                        <p className="lead">
                            <a className="btn btn-primary btn-lg" href="#" role="button">Learn more</a>
                        </p>
                    </div>
                </div>
                <NameList />
            </div>
        );
    }
}

ReactDOM.render(<Main />, document.getElementById('content'));