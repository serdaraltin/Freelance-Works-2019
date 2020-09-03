module.exports = function ProductReviewMapper() {
    const review = {};

    // add arg cb
    function map(_review, UndefinedProps = false) {
        review.ProductReviewID = _review.reviewID;
        review.ReviewerName = _review.name;
        review.EmailAddress = _review.email;
        review.ProductID = _review.productid;
        review.Comments = _review.review;
        review.Status = _review.status;
        review.Rating = _review.rating;
        review.ReviewDate = _review.CreatedAt;
        review.ModifiedDate = _review.LastUpdateAt;
        if(UndefinedProps){
            return deleteUndefinedProps()
        }
        return review;
    }

    function deleteUndefinedProps() {
        Object.keys(review).forEach(key => review[key] === undefined && delete review[key]) // delete undefined props
        return review;
    }

    return Object.freeze({
        map,
        deleteUndefinedProps
    });
};
