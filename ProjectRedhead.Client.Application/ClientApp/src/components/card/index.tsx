import React, { ReactNode } from 'react'

import './card.scss';
import { directive } from '@babel/types';

const Card = (props: { title?: string, children: ReactNode }) => (
	<div className="card-container">
		{props.title && <div className="title">
			{props.title}
		</div>}

		<div className="content">
			{props.children}
		</div>
	</div>
);

export default Card;
