import React, { ReactNode } from 'react';

import './box.scss';

const Box = (props: { children?: ReactNode }) => (
	<div className="box-container">
		{props.children}
	</div>
);

export default Box;

