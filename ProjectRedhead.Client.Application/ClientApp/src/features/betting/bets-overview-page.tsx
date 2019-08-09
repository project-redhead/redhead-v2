import React from 'react';
import Card, { Box } from '../../components/card';

import './bets-overview-page.scss';

const BetsOverviewPage = () => {
	return (
		<div className="page-entrance">
			<h1 className="header">Wetten</h1>
			<div className="trending-bet">
				<Box>
					<div>
						<h3>Wird die Bahn wieder zu spät kommen?</h3>
						<p className="author">- von <a href="">Gino</a></p>
					</div>

					<hr />

					<div>
						<button className="btn">Ja</button>
						<button className="btn">Nein</button>
						<button className="btn">Vielleicht</button>
					</div>
				</Box>
			</div>
		</div>
	);
};

export default BetsOverviewPage;
