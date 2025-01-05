import React from 'react';
import SeatBooking from './SeatBooking';

export default function TicketBook() {
    return (
        <>
            <button type="button" className="btn btn-info m-5" data-bs-toggle="modal" data-bs-target="#modal">
                Launch demo modal
            </button>

            <div className="modal fade" id="modal">
                <div className="modal-dialog modal-dialog-centered">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h1 className="modal-title fs-5" id="exampleModalLabel">How Many Seats?</h1>
                            <button type="button" className="btn-close" data-bs-dismiss="modal"></button>
                        </div>
                        <div className="modal-body">
                            <h5></h5>
                        </div>
                    </div>
                </div>
            </div>


            <SeatBooking />
        </>
    )
}
